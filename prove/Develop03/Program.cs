using System;

class Program


// had to get some help with this i was struggled to do it. i as had ai help to identy problems that i was not seeing.
// i over all dont think i did the gratest on this.
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();

        Console.Write("Enter scripture reference (e.g., John 3:16): ");
        scripture.Reference = Console.ReadLine();

        Console.Write("Enter scripture text: ");
        scripture.Text = Console.ReadLine();

        Console.Clear();
        DisplayScripture(scripture);

        while (true)
        {
            Console.Write("\nPress Enter to hide random words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.Text = scripture.HideRandomWords();
            Console.Clear();
            DisplayScripture(scripture);
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine($"Scripture Reference: {scripture.Reference}");
        Console.WriteLine($"Scripture Text: {scripture.Text}");
    }
}





