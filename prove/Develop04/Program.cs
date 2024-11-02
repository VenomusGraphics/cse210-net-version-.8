using System;

class Program
{
    static void Main(string[] args)
    {
           Console.WriteLine("Welcome to the Mindfulness App! are you ready to be mindefull today?");
        Console.WriteLine("Choose an activity by inputing a number!:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");

        int choice = int.Parse(Console.ReadLine());

        Activity activity = null;

        switch (choice)
        {
            case 1:
                activity = new BreathingActivity();
                break;
            case 2:
                activity = new ReflectionActivity();
                break;
            case 3:
                activity = new ListingActivity();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting.");
                return;
        }

        activity.StartActivity();
    }

}