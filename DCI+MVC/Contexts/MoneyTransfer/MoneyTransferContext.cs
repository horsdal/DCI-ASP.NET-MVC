using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCI_MVC.Contexts.MoneyTransfer
{
    public class TransferMoneyContext
    {
        public TransferMoneySource Source { get; private set; }
        public TransferMoneySink Sink { get; private set; }
        public decimal Amount { get; private set; }

        public TransferMoneyContext(TransferMoneySource source, TransferMoneySink sink, decimal amount)
        {
            Source = source;
            Sink = sink;
            Amount = amount;
        }

        public void Execute()
        {
            Source.TransferTo(Sink, Amount);
        }
    }
}