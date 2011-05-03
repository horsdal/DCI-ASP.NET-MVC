using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCI_MVC.Models.Repositories
{
    public class AccountRepository
    {
        private static List<Account> accounts = new List<Account>
                                                    {
                                                        new SavingsAccount(5000, "Lønkonto", 1),
                                                        new SavingsAccount(10000, "Ferie opsparing", 2),
                                                        new SavingsAccount(50000, "Opsparing", 3)
                                                    };

        public IEnumerable<Account> Accounts { get { return accounts; } }

        public Account GetById(int id)
        {
            return accounts.Find(a => a.Id == id);
        }
    }
}