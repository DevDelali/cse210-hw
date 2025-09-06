using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.Write("What is the magic number ?: ");
        int magicNumber = int.Parse(Console.ReadLine());

        int guessNumber = -1; // Initialize guessNumber to a value that can't be equal to magicNumber

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess number ?: ");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (magicNumber > guessNumber)
            {
                Console.WriteLine("Guess Higher!");
            }
            else
            {
                Console.WriteLine("Guess Lower!");
            }
        }
    }   
}