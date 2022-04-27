using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
        }

        private void Run()
        {
            int number;
            bool catchErrors = false;
            Console.Write("Enter a number: ");
            try
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine($"The number you have just entered is {number}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch (OverflowException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch (Exception e) when (catchErrors == true)
            {
                Console.WriteLine("HERE");
            }
            Console.WriteLine("After try..catch");
        }
    }
}
