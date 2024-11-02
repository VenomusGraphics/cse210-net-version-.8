class Game
{
    private Player player;
    private Location currentLocation;

    public Game()
    {
        player = new Player();
        currentLocation = new Location("You are in a dark forest.");
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Text Adventure Game!");

        while (player.Health > 0)
        {
            currentLocation.Explore();
            Console.WriteLine("What do you want to do? (Type 'quit' to exit)");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Game over. Thanks for playing!");
                break;
            }
            else if (input == "look around")
            {
                // Add code to generate random events, enemies, and items
                // For add-ons, create additional classes and incorporate them here
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}
