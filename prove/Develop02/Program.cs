using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        // Create instances of Journal, Prompt, and FileAction
        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        FileAction fileAction = new FileAction("journal.json");

        // Load data from the file (if it exists)
        fileAction.Load(journal, prompt);

        // Add a new entry to the journal
        Entry newEntry = new Entry()
        {
            Date = DateTime.Today,
            Prompt = prompt.Random(), // Get a random prompt
            Text = "Today, I started using the Journal class in my code."
        };
        journal.Write(newEntry);

        // Save the updated journal and prompt to the file
        fileAction.Save(journal, prompt);

        // Display the journal entries
        journal.Display();

        Console.WriteLine("Journal saved successfully.");        
    }
}