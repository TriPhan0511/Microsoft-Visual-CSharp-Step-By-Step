//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace SwitchStatementConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int measurement = 100;
            string range = measurement switch
            {
                < 0 => "negative",
                0 => "zero",
                >= 1 and <= 9 => "singledigit",
                >= 10 and <= 99 => "doubledigit",
                >= 100 => "large"
            };
            Console.WriteLine(range);
        }

        //static void Main(string[] args)
        //{
        //    string input = "inRange = (lo <= number) && (hi >= number) \" '";
        //    string output = ConvertIntoXML(input);
        //    Console.WriteLine(input);
        //    Console.WriteLine(output);
        //}

        private static string ConvertIntoXML(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                char item = input[i];
                switch (item)
                {
                    case '>':
                        output += "&gt;";
                        break;
                    case '<':
                        output += "&lt;";
                        break;
                    case '&':
                        output += "&amp;";
                        break;
                    case '"':
                        output += "&#34;";
                        break;
                    case '\'':
                        output += "&#39;";
                        break;
                    default:
                        output += item;
                        break;
                }
            }
            return output; 
        }

        private static string ReadInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (input == null || input.Length  == 0)
                {
                    Console.WriteLine("You should not enter an empty string.\n" +
                        "Please enter a string again.");
                }
                else
                {
                    return input;
                }
            }
        }
    }
}

