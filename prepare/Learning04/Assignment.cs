public class Assignments
{
    private string _StudentName;
    private string _topic;

    public Assignments(string studentName, string topic)
    {
        _StudentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"Student Name: {_StudentName}, Topic: {_topic}";
    }
}