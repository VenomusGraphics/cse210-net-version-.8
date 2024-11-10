class BreathingActivity : Activity
{
    protected override void PerformActivity()
    {
        Console.WriteLine("Clear your mind and focus on your breathing.");
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(8000); 
        }
    }
}