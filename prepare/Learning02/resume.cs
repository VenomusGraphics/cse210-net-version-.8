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