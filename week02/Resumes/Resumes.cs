public class Resumes
{
    public string _name = "name";
    public List<Job> _jobs = new List<Job>();
    
    public Resumes()
    {
        
    }

    public void DisplayJobs()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }

}