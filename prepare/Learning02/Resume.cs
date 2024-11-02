using System.Reflection.Metadata;


// i did not fully nderstnad what i need to do here so i looked at the sample solution because i was receiving errors
public class Resume
{
    public string _name;
    public List<JobsTitle> _Job = new List<JobsTitle>();

    public void Display()
    {
        Console.WriteLine($"name:{_name}");
        Console.WriteLine("Jobs");

        foreach (JobsTitle jobs in _Job)
        {
            jobs.Display();
        }
    }
    
}
