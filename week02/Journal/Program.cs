using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine();
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();
            string userInput = "";
            while (userInput != "5")
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(entry._promptText);
                    Console.Write("Your Response: ");
                    entry._entryText = Console.ReadLine();
                    journal.AddEntry(entry);
                }
                else if (userInput == "2")
                {
                    journal.DisplayAll();
                }
                else if (userInput == "3")
                {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                }
                else if (userInput == "4")
                {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                }
                else if (userInput == "5")
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }
    }
}