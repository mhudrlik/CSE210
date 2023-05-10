using System;
using System.Collections.Generic;

public class Prompt
{
    public List<string> prompts;

    public Prompt()
    {
        prompts = new List<string>();
    }

    public string Random()
    {
        if (prompts.Count == 0)
        {
            return "No prompts available.";
        }

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public void Display()
    {
        Console.WriteLine("Prompts:");
        foreach (var prompt in prompts)
        {
            Console.WriteLine(prompt);
        }
    }

    public void Add()
    {
        Console.Write("Enter a new prompt: ");
        string newPrompt = Console.ReadLine();
        prompts.Add(newPrompt);
        Console.WriteLine("Prompt added successfully.");
    }

    public void Remove()
    {
        Console.WriteLine("Select a prompt to remove:");
        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        Console.Write("Enter the number of the prompt to remove: ");
        if (int.TryParse(Console.ReadLine(), out int selectedIndex))
        {
            if (selectedIndex >= 1 && selectedIndex <= prompts.Count)
            {
                string removedPrompt = prompts[selectedIndex - 1];
                prompts.RemoveAt(selectedIndex - 1);
                Console.WriteLine($"Prompt '{removedPrompt}' removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid prompt number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
