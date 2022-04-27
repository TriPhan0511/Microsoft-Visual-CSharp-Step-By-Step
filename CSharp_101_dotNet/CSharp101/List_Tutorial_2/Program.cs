using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Tutorial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(new Program()).Sample1();
            (new Program()).Fibonacci_Sample();
        }

        void Fibonacci_Sample()
        {
            //var fibonacciNumbers = new List<int>() { 1, 1 };
            //var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            //fibonacciNumbers.Add(previous + previous2);

            var fibonacciNumbers = GetFibonacciNumbers(20);
            PrintFibonacciNumbers(fibonacciNumbers);
        }

        // List of first n number of Fibonaccion numbers
        private List<int> GetFibonacciNumbers(int n)
        {
            List<int> list = new List<int>() { 1, 1 };
            while (list.Count < 20)
            {
                var previous = list[list.Count - 1];
                var previous2 = list[list.Count - 2];
                list.Add(previous + previous2);
            }
            return list;
        }

        private static void PrintFibonacciNumbers(List<int> fibonacciNumbers)
        {
            foreach (var number in fibonacciNumbers)
            {
                Console.WriteLine(number);
            }
        }

        void Sample1()
        {
            //// Create a list
            //var names = new List<string>() { "Tri", "Anna", "Felipe" };
            ////// Print a list
            ////PrintList(names);

            //// Modify list contents
            //names.Add("Maria");
            //names.Add("Bill");
            //names.Remove("Anna");

            //// Print the list
            //PrintList(names);

            //// Access to the list contents using index
            //Console.WriteLine($"My name is {names[0]}.");
            //Console.WriteLine($"Last person in the list is {names[names.Count - 1]}");
            ////-----------------------------------------------------------------------------------------------------

            //// Search the list
            //// The IndexOf method searches for an item and returns the index of the item.
            //// If the item isn't in the list, IndexOf returns -1.
            //var names = new List<string>() { "Tri", "Anna", "Felipe", "Maria", "Bill" };

            //var index = names.IndexOf("Felipe");
            //if (index != -1)
            //{
            //    Console.WriteLine($"The name {names[index]} is at index {index}");
            //}

            //var notFound = names.IndexOf("Not found");
            //Console.WriteLine($"When an item is not found, IndexOf return {notFound}");
            ////-----------------------------------------------------------------------------------------------------
            ///

            // The items in your list can be sorted as well.
            // The Sort method sorts all the items in the list in their normal order (alphabetically for strings).
            var names = new List<string>() { "Tri", "Anna", "Felipe", "Maria", "Bill" };
            Console.WriteLine("\nBefore sorting:");
            PrintList(names);
            names.Sort(); // Sort
            Console.WriteLine("\nAfter sorting");
            PrintList(names);
        }

        private static void PrintList(List<string> names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
