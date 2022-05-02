// See https://aka.ms/new-console-template for more information
using MyBank;

var account = new BankAccount("Alex", 1000);
account.MakeWithdrawal(200, DateTime.Now, "Iphone 4");
account.MakeDeposit(550, DateTime.Now, "Friend pay back");
Console.WriteLine(account.GetTransactionLog());


