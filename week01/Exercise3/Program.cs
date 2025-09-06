using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.Write("What is the magic number ?: ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        Random random = new Random();

        int magicNumber = random.Next(101);
        Console.WriteLine("Random integer (0 to 100)");

        int guessNumber = -1;

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