using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DCI_MVC.Models
{
    public abstract class Account
    {
        public decimal Balance { get; protected set; }
        public int Id { get; private set; }
        public string Name { get; private set; }

        protected Account(decimal initialBalance, string name, int id)
        {
            Balance = initialBalance;
            Name = name;
            Id = id;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

}