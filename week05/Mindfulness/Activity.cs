public class Activity
{
    private string _name = "";
    private string _description = "";
    protected int _duration = 5;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"------------------------------Welcome to the {_name} Activity------------------------------");
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How Long, in seconds, do you want to spent in this activity? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!\n");
        ShowSpinner(3);
        Console.WriteLine($"You have spent {_duration} seconds in the {_name} Activity.");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {   
        List<string> spinner = ["|","/","—","\\", "|", "/", "—", "\\"];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now <= endTime)
        {   
            Console.Write(spinner[i]);
            Thread.Sleep(400);
            Console.Write("\b \b");
            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }  
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
              
    }
}