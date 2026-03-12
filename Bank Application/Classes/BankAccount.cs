using System.Collections.Generic;
using System.Linq;

namespace Bank_Application.NewFolder
{
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public List<Transition> Transitions { get; set; } = new List<Transition>();

        public void AddTransaction(decimal amount, TransactionType type, string desc)
        {
            Transitions.Add(new Transition { Amount = amount, Type = type, Description = desc });
            if (type == TransactionType.Income) Balance += amount;
            else Balance -= amount;
        }
    }
}