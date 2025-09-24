using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        System.Console.WriteLine(); // cw to get Console.WriteLine shortcut 

        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(
            """
            For God so loved the world that he gave his one and only Son, 
            that whoever believes in him shall not perish but have eternal life
            """);

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        // Loop until all words are hidden or user types 'quit'
        while (true)
        {
            Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit:");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideRandomWord();
            Console.WriteLine(scripture.GetDisplayText());

        }
    }
}
