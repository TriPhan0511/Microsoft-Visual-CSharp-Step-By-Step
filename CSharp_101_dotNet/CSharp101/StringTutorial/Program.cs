//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace StringTutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Work with strings

            //string aFriend = "Kendra";
            //Console.WriteLine($"Hello, {aFriend}");

            //string firstFriend = "Kendra";
            //string secondFriend = "Scott";
            //Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");
            //Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            //Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
            //-------------------------------------------------

            //// Trim, TrimStart, TrimEnd: Remove leading and trailing spaces
            //string greeting = "      Hello, World!     ";
            //Console.WriteLine($"[{greeting}]");

            //string trimmedGreeting = greeting.TrimStart();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //trimmedGreeting = greeting.TrimEnd();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //trimmedGreeting = greeting.Trim();
            //Console.WriteLine($"[{trimmedGreeting}]");
            //-------------------------------------------------

            //// Replace method: It searches for a substring and replaces it with different text.
            //string sayHello = "Hello World!";
            //Console.WriteLine(sayHello); // Hello World!

            //sayHello = sayHello.Replace("Hello", "Greetings");
            //Console.WriteLine(sayHello); // Greetings World!

            //sayHello = sayHello.Replace("World", "Kendra");
            //Console.WriteLine(sayHello); // Greeting Kendra!
            //-------------------------------------------------

            //// ToUpper, ToLower: Make a string ALL CAPS or all lower case
            //string sayHello = "Hello World!";
            //Console.WriteLine(sayHello.ToUpper()); // HELLO WORLD!
            //Console.WriteLine(sayHello.ToLower()); // hello world!
            //--------------------------------------------------------------------------------------------------------

            // Searching Strings

            //// Contains method: It tells you if a string contains a substring inside it.
            //string songLyrics = "You say goodbye, and I say hello";
            //var result = songLyrics.Contains("goodbye");
            //Console.WriteLine(result); // True
            //Console.WriteLine(songLyrics.Contains("greeting")); // False

            // StartsWith and EndsWith methods: search for substrings in a string,
            // These find a substring at the beginning or the end of the string.
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.StartsWith("You")); // True
            Console.WriteLine(songLyrics.StartsWith("goodbye")); // False
            Console.WriteLine(songLyrics.EndsWith("hello")); // True
            Console.WriteLine(songLyrics.EndsWith("goodbye")); // False

            Console.WriteLine("Hello");
        }
    }
}
