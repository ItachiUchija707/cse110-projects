using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Developer";
        job1._company = "BYU-Idaho";
        job1._startYear = 2000;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Chief Executive";
        job2._startYear = 1999;
        job2._endYear = 2009;
        Resumes resume = new Resumes();
        resume._name = "Axzam";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayJobs();
        

    }

}