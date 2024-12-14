using System;

class Program
{
    static void Main()
    {
        // Create some addresses
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");

        // Create events
        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in tech", "2023-10-05", "10:00 AM", address1, "Jane Doe", 100);
        Reception reception = new Reception("Networking Event", "A chance to network with professionals", "2023-10-12", "6:00 PM", address1, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Picnic in the Park", "A fun day out with friends", "2023-10-20", "12:00 PM", address2, "Sunny");

        // Store events in a list
        Event[] events = { lecture, reception, gathering };

        // Display event marketing messages
        foreach (Event ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}
