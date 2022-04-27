//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!!!!!");

using System;

namespace BranchesTutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("And the first answer is equal to the second number.");
            }
            else
            {
                Console.WriteLine("The anser is not greater than 10.");
                Console.WriteLine("Or the first number is not equal to the second number.");
            }
        }
    }
}
