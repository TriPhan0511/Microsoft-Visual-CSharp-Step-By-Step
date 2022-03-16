//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace NumberTutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int a = 18;
            //int b = 6;
            //int c = a + b;
            //Console.WriteLine(c); // 24
            //c = a - b;
            //Console.WriteLine(c); // 12
            //c = a * b;
            //Console.WriteLine(c); // 108
            //c = a / b;
            //Console.WriteLine(c); // 3
            // ---------------------------------------------------------

            //// Order of operations
            //int a = 5;
            //int b = 4;
            //int c = 2;  

            //int d = a + b * c;
            //Console.WriteLine(d); // 13
            //d = (a + b) * c;
            //Console.WriteLine(d); // 18
            //d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            //Console.WriteLine(d); // 25

            //int a = 7;
            //int b = 4;
            //int c = 3;
            //int d = (a + b) / c;
            //Console.WriteLine(d); // 3
            // ---------------------------------------------------------

            // Integer precision and limits
            //int a = 7;
            //int b = 4;
            //int c = 3;
            //int d = (a + b) / c;
            //int e = (a + b) % c;
            //Console.WriteLine($"quotient: {d}"); // 3
            //Console.WriteLine($"remainder: {e}"); // 2

            //int max = int.MaxValue;
            //int min = int.MinValue;
            //Console.WriteLine($"The range of integers is {min} to {max}");
            //int what = max + 3;
            //Console.WriteLine($"An example of overflow: {what}");
            // ---------------------------------------------------------

            //// Work with the double type
            //double a = 5;
            //double b = 4;
            //double c = 2;
            //double d = (a + b) / c; 
            //Console.WriteLine(d); // 4.5

            //double a = 19;
            //double b = 23;
            //double c = 8;
            //double d = (a + b) / c;
            //Console.WriteLine(d); // 5.25

            //double max = double.MaxValue;
            //double min = double.MinValue;
            //Console.WriteLine($"The range of double is {min} to {max}");

            //double third = 1.0 / 3.0; // 0.3333333333333333
            //Console.WriteLine(third);
            // ---------------------------------------------------------

            //// Work with fixed point types
            //// The decimal type has a smaller range but greater precision than double.

            //decimal max = decimal.MaxValue;
            //decimal min = decimal.MinValue;
            //Console.WriteLine($"The range of decimal type is {min} to {max}"); // -79228162514264337593543950335 to 79228162514264337593543950335

            //double a = 1.0;
            //double b = 3.0;
            //Console.WriteLine(a / b); // 0.3333333333333333

            //decimal c = 1.0M;
            //decimal d = 3.0M;
            //Console.WriteLine(c / d); // 0.3333333333333333333333333333
            // ---------------------------------------------------------

            //decimal min = decimal.MinValue;
            //decimal max = decimal.MaxValue;
            //Console.WriteLine($"The range of the decimal type is {min} to {max}");
            //// The range of the decimal type is -79228162514264337593543950335 to 79228162514264337593543950335

            //int min2 = int.MinValue;
            //int max2 = int.MaxValue;
            //Console.WriteLine($"The range of the int type is {min2} to {max2}");
            //// The range of the int type is -2147483648 to 2147483647

            //long min3 = long.MinValue;
            //long max3 = long.MaxValue;
            //Console.WriteLine($"The range of the long type is {min3} to {max3}");
            //// The range of the long type is -9223372036854775808 to 9223372036854775807

            //short min4 = short.MinValue;
            //short max4 = short.MaxValue;
            //Console.WriteLine($"The range of the short type is {min4} to {max4}");
            //// The range of the short type is -32768 to 32767

            //double min5 = double.MinValue;
            //double max5 = double.MaxValue;
            //Console.WriteLine($"The range of the double type is {min5} to {max5}");
            //// The range of the double type is -1.7976931348623157E+308 to 1.7976931348623157E+308
            ///// ---------------------------------------------------------

            // Calculate the area of a circle
            double radius = ReadRadius("Enter a radius: ");
            double area = calculateArea(radius);
            showResult(radius, area);

            static double calculateArea(double radius)
            {
                return radius * radius * Math.PI;
            }

            static void showResult(double radius, double area)
            {
                Console.WriteLine($"The area of the circle whose radius is {radius} is {area}");
            }
        }

        private static double ReadRadius(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong double. Please enter a radius again.");
                }
            }
            
        }
    }
}
