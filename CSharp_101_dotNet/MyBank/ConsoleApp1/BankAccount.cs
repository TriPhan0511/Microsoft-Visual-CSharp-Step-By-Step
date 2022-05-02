using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
        public string Number { get; }
        public string  Onwer { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount()
        {
        }

        public BankAccount(string onwer, decimal initialBalance)
        {
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            Onwer = onwer;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        private void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("The amount of deposit should be greater than zero.");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        private void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount of withdrawal should be greater than zero.");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetTransactionLog()
        {
            decimal balance = 0;
            StringBuilder report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tBalance");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date}\t{item.Amount}\t{balance}");
            }
            return report.ToString();
        }
    }
}
