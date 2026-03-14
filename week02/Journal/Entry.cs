
public class Entry
{
    public string _date;
    public string _randomPrompt;

    public List<string> _userEntry = new List<string>();

        public Entry(string prompt, List<string> userResponses)
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();

        _randomPrompt = prompt;
        _userEntry = userResponses;
        
    }

    public void Display() {
       Console.WriteLine($"{_date} -- {_randomPrompt}");
       Console.WriteLine($"{_userEntry[0]}");
       Console.WriteLine($"Your mood level was: {_userEntry[1]}");
       Console.WriteLine($"You were gratuful for: {_userEntry[2]}");
       Console.WriteLine();
    }

}