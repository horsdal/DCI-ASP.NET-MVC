using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DCI_MVC.Models.Repositories;

namespace DCI_MVC.Controllers
{
    public class AccountOverviewController : Controller
    {
        //
        // GET: /AccountOverview/

        public ActionResult Index()
        {
            ViewData["Accounts"] = new AccountRepository().Accounts;
            return View();
        }

    }
}
