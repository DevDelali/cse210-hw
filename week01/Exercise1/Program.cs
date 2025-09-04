using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("Please enter your first name :");
        string first_name = Console.ReadLine().ToUpper(); // capitalizing the first name
        Console.Write("Please enter your last name :");
        string last_name = Console.ReadLine().ToUpper();  // capitalizing the last name
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}      