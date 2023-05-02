public class Resume
{
    public string name = "";
    public List<Job> Job = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");
        foreach (Job item in Job)
        {
            item.Display();
        }
    }
}