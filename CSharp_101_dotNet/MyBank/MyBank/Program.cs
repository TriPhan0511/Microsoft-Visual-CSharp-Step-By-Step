// See https://aka.ms/new-console-template for more information
using Classes;

//var account = new BankAccount("Alex", 1000);
//account.MakeWithdrawal(200, DateTime.Now, "Iphone 4");
//account.MakeDeposit(550, DateTime.Now, "Friend pay back");
//Console.WriteLine(account.GetAccountHistory());

var account = new BankAccount("Alex Ferguson", 1000);
Console.WriteLine($"{account.Number} is created for {account.Onwer} with {account.Balance} initial balance.");

var account2 = new InterestEarningAccount("Peter", 500);
Console.WriteLine($"{account2.Number} is created for {account2.Onwer} with {account2.Balance} initial balance.");

Console.WriteLine(account.GetType());
//if (account.GetType() == typeof(BankAccount))
//if (account2.GetType() == typeof(BankAccount))
if (account2.GetType() == typeof(InterestEarningAccount))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

