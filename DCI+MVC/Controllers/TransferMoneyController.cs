using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DCI_MVC.Contexts.MoneyTransfer;
using DCI_MVC.Models;
using DCI_MVC.Models.Repositories;

namespace DCI_MVC.Controllers
{
    public class TransferMoneyController : Controller
    {
        AccountRepository accountRepo = new AccountRepository();
         
        public ActionResult Index()
        {

            ViewData["SourceAccounts"] =
                accountRepo.Accounts.Select(a => new SelectListItem {Text = a.Name, Value = a.Id.ToString()});
            ViewData["DestinationAccounts"] =
                accountRepo.Accounts.Select(a => new SelectListItem {Text = a.Name, Value = a.Id.ToString()});
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(FormCollection form)
        {
            var sourceAccountId = form["SourceAccounts"];
            var destinationAccountId = form["DestinationAccounts"];
            var amount = form["Amount"];

            var sourceAccount = accountRepo.GetById(int.Parse(sourceAccountId));
            var destinationAccount = accountRepo.GetById(int.Parse(destinationAccountId));

            var ctx = new TransferMoneyContext(sourceAccount as TransferMoneySource, 
                destinationAccount as TransferMoneySink, 
                decimal.Parse(amount));
            ctx.Execute();

            return ResultPage(ctx);
        }
        
        public ActionResult SelectSource()
        {
            Session["Context"] = new TransferMoneyContext();
            return View(new SelectAccountVm
                            {
                                SelectedAccountId = string.Empty,
                                Accounts = accountRepo.Accounts
                            });
        }

        [HttpPost]
        public ActionResult SelectSource(SelectAccountVm model)
        {
            var ctx = Session["Context"] as TransferMoneyContext;
            ctx.Source = 
                accountRepo.GetById(int.Parse(model.SelectedAccountId)) as TransferMoneySource;
            return View("SelectDestination", 
                        new SelectAccountVm
                            {
                                SelectedAccountId = string.Empty,
                                Accounts = accountRepo.Accounts
                            });
        }

        [HttpPost]
        public ActionResult SelectDestination(SelectAccountVm model)
        {
            var ctx = Session["Context"] as TransferMoneyContext;
            ctx.Sink = 
                accountRepo.GetById(int.Parse(model.SelectedAccountId)) as TransferMoneySink;
            return View("SelectAmount", new SelectAmountVm());
        }

        [HttpPost]
        public ActionResult SelectAmount(SelectAmountVm model)
        {
            var ctx = Session["Context"] as TransferMoneyContext;
            ctx.Amount = model.SelectedAmount;

            ctx.Execute();

            return ResultPage(ctx);
        }

        private ActionResult ResultPage(TransferMoneyContext ctx)
        {
            ViewData["Amount"] = ctx.Amount;
            ViewData["Source"] = ((Account)ctx.Source).Name;
            ViewData["Destination"] = ((Account)ctx.Sink).Name;
            return View("Result");
        }
    }

    public class SelectAmountVm 
    {
        public decimal SelectedAmount { get; set; }
    }

    public class SelectAccountVm 
    {
        public String SelectedAccountId { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
    }
}
