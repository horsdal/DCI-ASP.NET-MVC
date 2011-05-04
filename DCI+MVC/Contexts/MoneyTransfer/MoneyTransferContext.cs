using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCI_MVC.Contexts.MoneyTransfer
{
    public class TransferMoneyContext
    {
        public TransferMoneySource Source { get;  set; }
        public TransferMoneySink Sink { get; set; }
        public decimal Amount { get; set; }

        public TransferMoneyContext()
        {
            
        }

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