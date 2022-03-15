//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello("Good morning");
            Console.WriteLine(SayHello(100));
        }

        private static void SayHello(string greeting) => Console.WriteLine(greeting);
        private static int SayHello(int number) => number;
    }
}
