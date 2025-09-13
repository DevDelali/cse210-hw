using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{    public List<Entry> _entries = new List<Entry>(); // list to hold all journal entries
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll() // display all entries
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        SaveToFile("journal.txt");
    }
    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving To File.....");
        string filename = "journal.txt"; 

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} {entry._promptText}");
                outputFile.WriteLine($"{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reading From File");
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line); 
        }
    }
}
