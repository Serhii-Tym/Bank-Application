using System;

namespace Bank_Application.NewFolder
{
    public enum TransactionType { Income, Expense }

    internal class Transition
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            string sign = Type == TransactionType.Income ? "+" : "-";
            return $"{Date:dd.MM HH:mm} | {sign}${Amount:F2} | {Description}";
        }

    }
}