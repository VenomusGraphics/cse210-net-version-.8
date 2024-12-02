using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Add (1) reference or Use (2) reference");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
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
                Console.Write("Press Enter to hide random words or type 'quit' to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                scripture.Text = scripture.HideRandomWords();
                Console.Clear();
                DisplayScripture(scripture);
            }
        }
        else if (choice == 2)
        {
            Scripture scripture = new Scripture
            {
                Reference = "John 3:16",
                Text = "For God so loved the world that He gave His only begotten Son"
            };

            Console.Clear();
            DisplayScripture(scripture);

            while (true)
            {
                Console.Write("Press Enter to hide random words or type 'quit' to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                scripture.Text = scripture.HideRandomWords();
                Console.Clear();
                DisplayScripture(scripture);
            }
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine($"Scripture Reference: {scripture.Reference}");
        Console.WriteLine($"Scripture Text: {scripture.Text}");
    }
}
