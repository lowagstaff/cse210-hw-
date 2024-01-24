public class Resume
{
    public string _name = "";

    public Resume()
    {  
    }

    public List<Job> _jobs = new List<Job>();

    public void display()
    {
    
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach(Job job in _jobs)
        {
            job.display();
        }
    }
}