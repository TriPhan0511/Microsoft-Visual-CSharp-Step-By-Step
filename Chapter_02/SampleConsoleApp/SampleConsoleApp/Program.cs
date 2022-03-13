// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int myInt, myInt2, myInt3 = 10;
//Console.WriteLine(myInt3);    // 10
////Console.WriteLine(myInt); // error


//int count = 10;

//count++; // postfix increment
//Console.WriteLine(count); // 11
//++count; // prefix incremnt
//Console.WriteLine(count); // 12

//count--; // postfix decrement
//Console.WriteLine(count); // 11
//--count; // prefix decrement
//Console.WriteLine(count); // 10


//int x;

//x = 42;
//Console.WriteLine(x++); // x is now 43, 42 written out

//x = 42;
//Console.WriteLine(++x); // x is now 43, 43 written out

//// Declaring implicitly typed local variables
//var myVariable = 99;
//Console.WriteLine(myVariable + 100); // 199

//var myAnotherVariable = "Hello, world!";
//Console.WriteLine(myAnotherVariable + 100); // Hello, world!100

////myVariable = "Aloha"; // error
////var yetAnotherVariable; // error

//Convert a string to int
string s = "100";

int number = int.Parse(s);
Console.WriteLine(number + 5); // 105

int number2 = Int32.Parse(s);
Console.WriteLine(number2 + 5); // 105