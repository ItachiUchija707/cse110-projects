public class BreathingActivity : Activity
{
    public BreathingActivity(): base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime= DateTime.Now;
        DateTime endTime= startTime.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {   
            Console.Write("\n\nBreath in ");
            ShowCountDown(4);
            
            Console.Write("\n\nBreath out ");
            ShowCountDown(6);
            Console.WriteLine();
        } 

        DisplayEndingMessage();
    }
}