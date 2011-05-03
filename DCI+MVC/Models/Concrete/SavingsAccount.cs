using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DCI_MVC.Contexts.MoneyTransfer;

namespace DCI_MVC.Models
{
    public class SavingsAccount : Account, TransferMoneySource, TransferMoneySink
    {
        public SavingsAccount(decimal initialBalance, string name, int id) : base(initialBalance, name, id)
        {
        }

        public override string ToString()
        {
            return "Balance " + Balance;
        }
    }

}