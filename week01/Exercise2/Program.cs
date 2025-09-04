using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage :");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);
        string letter = "";
        string symbol = "";
        int lastDigit = grade % 10; // Getting last digit

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            Console.WriteLine("Your letter grade is F");
        }

        //stretch Requirements
        if (lastDigit >= 7)
        {
            symbol = "+";
        }
        else if (lastDigit<3)
        {
            symbol = "-";
        }
        else
        {
            symbol = null;
        }
        if (grade > 93)
        {
            symbol = null;
        }
        if (grade<= 60)
        {
            symbol = null;
        }
        Console.WriteLine($"Your letter grade is {letter} {symbol}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations ! You passes the course.");
        }
        else
        {
            Console.WriteLine("Wishing you all the best next time !");
        }
    }

}
