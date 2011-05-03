using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DCI_MVC.Contexts.MoneyTransfer;
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

            new TransferMoneyContext(sourceAccount as TransferMoneySource, destinationAccount as TransferMoneySink, decimal.Parse(amount)).Execute();

            ViewData["Amount"] = amount;
            ViewData["Source"] = sourceAccount.Name;
            ViewData["Destination"] = destinationAccount.Name;

            return View("Result");
        }

    }
}
