
class Activity
{
    protected int duration;
    protected string[] commonQuestions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Activity()
    {
        Console.WriteLine("Enter the duration of the activity (in seconds):");
        duration = int.Parse(Console.ReadLine());
    }

    public void StartActivity()
    {
        Console.WriteLine("This activity will help you relax by walking you through...");
        // Display a common starting message and prepare to begin.
        Thread.Sleep(2000);
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);

        PerformActivity();

        // Display a common finishing message after activity completion.
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"Activity: {GetType().Name}, Duration: {duration} seconds");
    }

    protected virtual void PerformActivity()
    {
        // Perform the specific activity here.
    }
}