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

        using (StreamWriter writerFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writerFile.WriteLine($"{entry._date} {entry._promptText}");
                writerFile.WriteLine($"{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string fil)
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
