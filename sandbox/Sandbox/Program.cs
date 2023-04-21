using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        //Defined Types
        //Declare then initialize
        int x;
        x = 5;
        Console.WriteLine(x);

        //Declare and initialize in one statement
        int y = 6;
        Console.WriteLine(y);

        //Common Types
        //int, string, float, double, bool

        //Input and Output
        //Output - No new line afterward
        Console.Write("There will not be a newline after this.");
        //Output - Including new line
        Console.WriteLine("Hello World!");

        //Input
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();

        //Blocks
        if (x < y)
            {
                Console.WriteLine("greater");
            }

        //String Interpolation
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");
    }
}