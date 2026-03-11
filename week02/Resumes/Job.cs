public class Job
{
    public string _jobTitle = "Job Title";
    public int _startYear = 0000;
    public int _endYear = 0000;
    public string _company = "Company";

    public Job()
    {
        
    }
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    
}


