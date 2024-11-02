public class WritingAssignment : Assignments
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title, string writingType)
        : base(studentName, topic)
    {
        _title = title; // Corrected variable name

    }

    public string GetWritingInformation()
    {

       return $"book title: {_title}";
    }
}