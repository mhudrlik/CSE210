using System;
using System.Collections.Generic;

public class Journal
{
    public DateTime Created { get; set; }
    public string Name { get; set; }
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void Write(Entry entry)
    {
        Entries.Add(entry);
    }

    public void Erase(Entry entry)
    {
        Entries.Remove(entry);
    }

    public void Display()
    {
        Console.WriteLine("Created: " + Created.ToString("yyyy-MM-dd"));
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Entries:");
        foreach (var entry in Entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
}
