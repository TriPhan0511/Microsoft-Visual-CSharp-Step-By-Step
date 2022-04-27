using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(new Program()).Run();
            (new Program()).Run2();
            Console.ReadLine(); // Pause the program
        }

        // List of numbers
        void Run2()
        {
            //var fibonacciNumbers = new List<int>() { 1, 1 };

            //var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            //fibonacciNumbers.Add(previous + previous2);

            //foreach (var item in fibonacciNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //// Find first twenty Fibonaccy numbers (hint: the 20th Fibonacci number is 6765)
            //List<int> FibonacciNumbers = FindFirstTwentyFibonacciNumbers();
            //foreach (var item in FibonacciNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            var fibonacciNumbers = new List<int>() { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }

        private List<int> FindFirstTwentyFibonacciNumbers()
        {
            var fibonacciNumbers = new List<int>() { 1, 1 };
            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }
            return fibonacciNumbers;
        }

        //private List<int> FindFirstTwentyFibonacciNumbers()
        //{
        //    var fibonacciNumbers = new List<int>() { 1, 1 };
        //    int previous, previous2;
        //    int i = 1;
        //    while (i <= 18)
        //    {
        //        previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        //        previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
        //        fibonacciNumbers.Add(previous + previous2);
        //        i++;
        //    }
        //    return fibonacciNumbers;
        //}

        // List of strings
        void Run()
        {
            var names = new List<string>() { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();

            // Modify the list
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();

            //// Reference individual items by index
            //Console.WriteLine($"My name is {names[0]}.");
            //Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

            //Console.WriteLine($"The list has {names.Count()} people in it.");

            //// Search an item
            //var index = names.IndexOf("Felipe");
            //if (index != -1)
            //{
            //    Console.WriteLine($"The name {names[index]} is at index {index}");
            //}

            //var notFound = names.IndexOf("Not Found");
            //Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            // The Sort method sorts all items in the list in their normal order (alphabetically for strings)
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
