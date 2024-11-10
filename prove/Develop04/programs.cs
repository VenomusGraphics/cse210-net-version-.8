using System;
using System.Diagnostics;
using System.Net.Quic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Plesas sclect an activity by number.");
        Console.WriteLine(" 1- Breathing");
        Console.WriteLine(" 2- Refection");
        Console.WriteLine(" 3- Listing");
        Console.WriteLine(" 4- quit");

        int UserInput =int.Parse(Console.ReadLine());

        Activity activity= null;

        switch (UserInput)
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
            case 4:
                activity = new ();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting.");
                return;
        }

        activity.StartActivity();
    }
    
}