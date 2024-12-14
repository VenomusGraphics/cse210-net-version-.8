using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create activities
        Running running = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 20);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 40);

        // Store activities in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
