public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Text { get; set; }

    public void Display()
    {
        Console.WriteLine("Date: " + Date.ToString("yyyy-MM-dd"));
        Console.WriteLine("Prompt: " + Prompt);
        Console.WriteLine("Text: " + Text);
    }
}
