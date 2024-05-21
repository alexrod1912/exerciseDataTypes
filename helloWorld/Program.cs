// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Naomi!");
Console.WriteLine("What is your name");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);
Console.WriteLine("Please provide a length value for your rectangle");
string length = Console.ReadLine();
int lengthInt = int.Parse(length);
Console.WriteLine("Please provide a width ");
string width = Console.ReadLine();
int widthInt = int.Parse(width);
Console.WriteLine("Your rectangles area is " + widthInt * lengthInt);