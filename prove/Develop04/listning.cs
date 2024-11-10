class ListingActivity : Activity
{
    private Random random = new Random();
    private List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void PerformActivity()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life.by having you list as many things as you can in a certain area.");

        Console.WriteLine(GetRandomPrompt());
        Thread.Sleep(5000); // Initial 5-second countdown.
        int itemsListed = 0;
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Enter an item or enter ('done') to finish listing:");
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
                break;
            itemsListed++;
        }
        Console.WriteLine($"Number of items listed: {itemsListed}");
    }

    private string GetRandomPrompt()    
    {
        return listingPrompts[random.Next(listingPrompts.Count)];
    }
}