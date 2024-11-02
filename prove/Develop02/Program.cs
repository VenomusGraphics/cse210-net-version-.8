using System;
using System.Dynamic;
using System.Runtime.InteropServices.Marshalling;

public class Program
{
    static Journal journal = new Journal(); // Create an instance of the Journal class!

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        while (true) // Keep looping until the user chooses to quit!
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add entry to journal");
            Console.WriteLine("2. View journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit journal program");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // Creates an instance of the Prompt class
                    Prompt prompt = new Prompt();

                    // Gets a random prompt
                    string writingPrompt = prompt.GetRandomPrompt();

                    Console.WriteLine("Your writing prompt is: " + writingPrompt);

                    // Asks the user to provide an entry text
                    Console.WriteLine("Enter your journal entry:");
                    string entryText = Console.ReadLine();

                    // Creates a new Entry object
                    Entry newEntry = new Entry
                    {
                        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        PromptText = writingPrompt,
                        EntryText = entryText
                    };

                    // Adds the new entry to the journal
                    journal.AddEntry(newEntry);

                    Console.WriteLine("Entry added to journal!");
                    break;

                case 2:
                    // Implement code for viewing journal
                    Console.WriteLine("Journal Entries:");
                    journal.DisplayAll();
                    break;

                case 3:
                    // Implement code for saving journal to a text file
                    Console.WriteLine("Enter the file name to save the journal (e.g., journal.txt):");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case 4:
                    // Implement code for loading journal from a text file
                    Console.WriteLine("Enter the file name to load the journal (e.g., journal.txt):");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case 5:
                    Environment.Exit(0); // Quit the program
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }

    // ... Rest of your code ...
}