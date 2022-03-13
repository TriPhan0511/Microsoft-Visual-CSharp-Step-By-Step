// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.WriteLine("12" + "3");

//int intVar = 100;
//Console.WriteLine(intVar.ToString());

//string stringVar = "45";
//Console.WriteLine(stringVar + 1); // 451
//Console.WriteLine(Int32.Parse(stringVar) + 1); // 46

//String interpolation

//var name = "John";
//Console.WriteLine($"Good morning, {name}!"); // Good morning, John!

//var username = "Hillary";
//var greeting = ($"Hello, {username}!");
//Console.WriteLine(greeting); // Hello, Hillary!

//Console.WriteLine($"Aloha, {username}. You are {10+28} years old."); // Aloha, Hillary. You are 38 years old.

////Division
//Console.WriteLine(5.0 / 2.0); // 2.5 (the type of both operands is double, so the type of the result is also double)
//Console.WriteLine(5 / 2); // 2 (the type of both operands is integer, so the type of the result is also integer)

//Console.WriteLine(5.0 / 2); // 2.5 (poor practice)
//Console.WriteLine(5 / 2.0); // 2.5 (poor practice)

////Remainder (or modulus)
//Console.WriteLine(9 % 2); // 1
//Console.WriteLine(9.0 % 2); // 1
//Console.WriteLine(9.0 % 2.0); // 1

//Console.WriteLine(7 % 2.4); // 2.2

//Infinity and NaN
//Console.WriteLine(5 / 0); // error

Console.WriteLine(5.0 / 0); // Infinity
Console.WriteLine(5 / 0.0); // Infinity
Console.WriteLine(0.0 / 0.0); // NaN (not a number)

//NaN and Infinity propagate through expressions
Console.WriteLine(10 + (0.0/0.0)); // NaN
Console.WriteLine(10 + (5.0/0.0)); // Infinity
Console.WriteLine((5.0 / 0) + (0.0 / 0.0)); // NaN

