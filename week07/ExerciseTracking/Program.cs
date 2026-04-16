using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        RunningActivity running = new RunningActivity("15 Abr 2026", 30, 2);
        SwimmingActivity swimming = new SwimmingActivity("16 Abr 2026", 40, 50);
        CyclingActivity cycling = new CyclingActivity("18 Abr 2026", 20, 40);
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.DisplayActivityInfo());
        }
    }
}