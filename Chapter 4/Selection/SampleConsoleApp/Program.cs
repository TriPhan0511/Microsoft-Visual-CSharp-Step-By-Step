//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace SampleConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            // int type
            //int day = ReadDay("Enter a day: ");
            //DisplayADay(day);

            // string type
            //string day = ReadDay2("Enter a day: ");
            //DisplayADay2(day);

            // char type
            char day = ReadDay3("Enter a day: ");
            DisplayADay3(day);
        }

        // Helper method
        private void DisplayADay3(char day)
        {
            string dayName;
            switch (day)
            {
                case '0':
                    dayName = "Sunday";
                    break;
                case '1':
                    dayName = "Monday";
                    break;
                case '2':
                    dayName = "Tuesday";
                    break;
                case '3':
                    dayName = "Wednesday";
                    break;
                case '4':
                    dayName = "Thursday";
                    break;
                case '5':
                    dayName = "Friday";
                    break;
                case '6':
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Unknown";
                    break;
            }
            Console.WriteLine(dayName);
        }

        // Helper method
        private char ReadDay3(string prompt)
        {
            Console.Write(prompt);
            return (char)Console.Read();
        }

        // Helper method
        private void DisplayADay2(string day)
        {
            string dayName;
            switch (day)
            {
                case "0":
                    dayName = "Sunday";
                    break;
                case "1":
                    dayName = "Monday";
                    break;
                case "2":
                    dayName = "Tuesday";
                    break;
                case "3":
                    dayName = "Wednesday";
                    break;
                case "4":
                    dayName = "Thursday";
                    break;
                case "5":
                    dayName = "Friday";
                    break;
                case "6":
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Unknown";
                    break;
            }
            Console.WriteLine(dayName);
        }

        // Helper method
        private string ReadDay2(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string day = Console.ReadLine();
                if (day != null && !day.Equals(""))
                {
                    return day;
                }
                else
                {
                    Console.WriteLine("You should enter a valid day (0-6).");
                }
            }
        }

        // Helper method
        private static void DisplayADay(int day)
        {
            string dayName;
            switch (day)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Unknown.";
                    break;
            }
            Console.WriteLine(dayName);
        }

        // Helper method
        private int ReadDay(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input. Please enter an integer.");
                }
            }

        }
    }
}
