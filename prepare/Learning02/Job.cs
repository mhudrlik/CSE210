public class Job
{
    public string company = "";
    public string title = "";
    public int startYear;
    public int endYear;

    public void Display()
    {
        Console.WriteLine($"{title} ({company}) {startYear}-{endYear}");
    }
}