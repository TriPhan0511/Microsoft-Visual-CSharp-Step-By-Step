//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Methods_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            playGame();
        }

        static void playGame()
        {
            int first = 0;
            int second = 0;
            //Get the first number from the user
            first = getNumberFromUser("Enter the first number: ");
            //Get the second number from the user
            second = getNumberFromUser("Enter the second number: ");

            bool keepCalculating = true;
            while (keepCalculating)
            {
                Console.WriteLine("\nEnter 1 for addition");
                Console.WriteLine("Enter 2 for subtraction");
                Console.WriteLine("Enter 3 for multiplication");
                Console.WriteLine("Enter 4 for division");
                Console.WriteLine("Enter 5 for remainder");
                Console.WriteLine("Enter 6 to exit the program");
                Console.Write("\nYour choice: ");
                int choice = 0;
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                int calculatedValue = 0;
                switch (choice)
                {
                    case 1:
                        calculatedValue = addValues(first, second);
                        showResult(calculatedValue);
                        break;
                    case 2:
                        calculatedValue = subtractValues(first, second);
                        showResult(calculatedValue);
                        break;
                    case 3:
                        calculatedValue = multiplyValues(first, second);
                        showResult(calculatedValue);
                        break;
                    case 4:
                        calculatedValue = divideValues(first, second);
                        showResult(calculatedValue);
                        break;
                    case 5:
                        calculatedValue = remainderValues(first, second);
                        showResult(calculatedValue);
                        break;
                    case 6:
                        keepCalculating = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice. Please try again!");
                        break;
                }
            }
        }

        static int getNumberFromUser(string prompt)
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            }
            return number;
        }

        static void showResult(int calculatedValue) => Console.WriteLine(calculatedValue);
        static int remainderValues(int first, int second)
        {
            Console.WriteLine($"{first} % {second}");
            return first % second;
        }
        static int divideValues(int first, int second)
        {
            Console.WriteLine($"{first} / {second}");
            return first / second;
        }
        static int multiplyValues(int first, int second)
        {
            Console.WriteLine($"{first} x {second}");
            return first * second;
        }
        static int subtractValues(int first, int second)
        {
            Console.WriteLine($"{first} - {second}");
            return first - second;
        }
        static int addValues(int first, int second)
        {
            Console.WriteLine($"{first} + {second}");
            return first + second;
        }
    }
}
