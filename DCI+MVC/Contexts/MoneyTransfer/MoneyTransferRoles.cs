using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCI_MVC.Contexts.MoneyTransfer
{
    public interface TransferMoneySink
    {
        void Deposit(decimal amount);
        void Log(string message);
    }

    public interface TransferMoneySource
    {
        decimal Balance { get; }
        void Withdraw(decimal amount);
        void Log(string message);
    }

    public static class TransferMoneySourceTrait
    {
        public static void TransferTo(this TransferMoneySource self, TransferMoneySink recipient, decimal amount)
        {
            // The implementation of the use case
            if (self.Balance < amount)
            {
                throw new ApplicationException(
                    "insufficient funds");
            }

            self.Withdraw(amount);
            self.Log("Withdrawing " + amount);
            recipient.Deposit(amount);
            recipient.Log("Depositing " + amount);
        }
    }
}