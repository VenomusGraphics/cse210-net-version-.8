using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Text Adventure Game!");

        Game textAdventureGame = LoadOrCreateGame(); // Load or create a new game

        textAdventureGame.Start();

       
    static Game LoadOrCreateGame()
    {
        Console.WriteLine("Load a saved game? (yes/no): ");
        string input = Console.ReadLine().ToLower();

       
        return new Game(); // Create a new game if not loading a saved game
    }
 }
 }