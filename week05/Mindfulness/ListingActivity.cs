using System.Security;

public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = new List<string>(["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"]);


    public ListingActivity(): base ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30)
    {
      
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nWrite down as many things you can");
        GetRandomPrompt();
        Console.Write("You may start in: ");
        ShowCountDown(5);
        Console.WriteLine();
        List<string> entries = GetListFromUser();
        _count = entries.Count;
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomPrompt]);
        
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime= DateTime.Now;
        DateTime endTime= startTime.AddSeconds(_duration);
        List<string> userEntries = new List<string>();
        while (DateTime.Now < endTime) 
        {
            Console.Write("> ");
            string userEntry = Console.ReadLine();
            userEntries.Add(userEntry);  
        }
        return userEntries;
    }
}