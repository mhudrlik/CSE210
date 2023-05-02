using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1.title = "Software Engineer";
        job1.company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

        Job job2 = new Job();
        job2.title = "Manager";
        job2.company = "Apple";
        job2.startYear = 2022;
        job2.endYear = 2023;

        Resume myResume = new Resume();
        myResume.name = "Allison Rose";

        myResume.Job.Add(job1);
        myResume.Job.Add(job2);

        myResume.Display();
    }
}