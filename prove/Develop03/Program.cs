// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Scripture object
        Scripture scripture = new Scripture();

        // Ask for the scripture reference and text
        Console.Write("Enter scripture reference (e.g., John 3:16): ");
        scripture.Reference = Console.ReadLine();

        Console.Write("Enter scripture text: ");
        scripture.Text = Console.ReadLine();

        // Clear the console and display the scripture
        Console.Clear();
        DisplayScripture(scripture);
    }

    // Method to display the scripture details
    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine($"Reference: {scripture.Reference}");
        Console.WriteLine($"Text: {scripture.Text}");
    }
}
