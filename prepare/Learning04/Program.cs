using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        // Create a WritingAssignment object
        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "Essay", "The Art of Writing", "Descriptive");

        // Call the GetSummary and GetWritingInformation methods and display the results
        string summary = writingAssignment.GetSummary();
        string writingInfo = writingAssignment.GetWritingInformation();

        Console.WriteLine(summary);
        Console.WriteLine(writingInfo);
    }
}