class ReflectionActivity : Activity
{
    private Random random = new Random();

    protected override void PerformActivity()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");

        for (int i = 0; i < duration;)
        {
            Console.WriteLine(GetRandomPrompt());
            i += 10; // Move to the next question after 10 seconds.
            for (int j = 0; j < 10; j++)
            {
                Console.Write("-"); // Display a countdown timer during each pause.
                Thread.Sleep(1000); // Show countdown for 1 second.
                Console.Write("\b \b"); // Overwrite the countdown timer.
            }
        }
    }
    private string GetRandomPrompt()
    {
        return commonQuestions[random.Next(commonQuestions.Length)];
    }
}