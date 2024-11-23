using System;

public class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Add New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Player Info");
            Console.WriteLine("4. List Goals");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist):");
                    int goalType = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter goal name:");
                    string goalName = Console.ReadLine();

                    Console.WriteLine("Enter goal description:");
                    string goalDescription = Console.ReadLine();

                    Console.WriteLine("Enter points for the goal:");
                    int goalPoints = int.Parse(Console.ReadLine());

                    if (goalType == 1)
                    {
                        goalManager.AddGoal(new SimpleGoal(goalName, goalDescription, goalPoints));
                    }
                    else if (goalType == 2)
                    {
                        goalManager.AddGoal(new EternalGoal(goalName, goalDescription, goalPoints));
                    }
                    else if (goalType == 3)
                    {
                        Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist):");
                        int target = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter bonus points for completing the checklist:");
                        int bonus = int.Parse(Console.ReadLine());

                        goalManager.AddGoal(new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus));
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter the goal index to record an event for:");
                    int goalIndex = int.Parse(Console.ReadLine());
                    goalManager.RecordEvent(goalIndex);
                    break;

                case 3:
                    goalManager.DisplayPlayerInfo();
                    break;

                case 4:
                    goalManager.ListGoals();
                    break;

                case 5:
                    goalManager.SaveGoals();
                    break;

                case 6:
                    goalManager.LoadGoals();
                    break;

                case 7:
                    Environment.Exit(0); // Exit the program
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }
        }
    }
}
