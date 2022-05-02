using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank_2
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
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
        private int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                //throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
                throw new ArgumentOutOfRangeException($"Amount of deposit must be positive (Parameter 'amount')");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetTransactionLog()
        {
            decimal balance = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Date\t\tAmount\tBalance");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                sb.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}");
            }

            return sb.ToString();
        }

    }
}
