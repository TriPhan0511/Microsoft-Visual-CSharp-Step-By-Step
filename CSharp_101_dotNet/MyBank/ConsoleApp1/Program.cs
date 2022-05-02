using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            try
            {
                //account = new BankAccount("Alex Ferguson", 1000);
                account = new BankAccount("Alex Ferguson", -1000);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            if (account.Onwer != null)
                //if (account.Onwer.Length == 0)
            {
                Console.WriteLine($"{account.Number} is created for {account.Onwer} with {account.Balance} initial balance.");
            }
            else
            {
                Console.WriteLine("NULL");
            }
            
        }
    }
}
