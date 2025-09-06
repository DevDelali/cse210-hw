using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (enter 0 to stop): ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }

        Console.WriteLine(); // lIne spacing
        // Displaying the numbers in the list
        Console.WriteLine("You entered the following numbers : ");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine(); // lIne spacing
        //Calculating the sum of the numbers 
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The total Sum of Numbers is {sum}");

        Console.WriteLine(); // lIne spacing
        //Calculating the average of the numbers 
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is {average}");

        Console.WriteLine(); // lIne spacing
        //Maximum number in the list
        int max = numbers[0];
        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is {max}");
        
         Console.WriteLine(); // lIne spacing
        //Minimum number in the list
        int min = numbers[0];
        foreach (var number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The minimum number is {min}");


    }
}