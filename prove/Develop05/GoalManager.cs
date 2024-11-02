public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int playerScore = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

public void RecordEvent(int goalIndex)
{
    if (goalIndex >= 0 && goalIndex < goals.Count)
    {
        int pointsEarned = goals[goalIndex].RecordEvent();
        playerScore += pointsEarned;
    }
}
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your Score: {playerScore}");
    }

    public void ListGoals()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i}. {goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filePath)
{
    goals.Clear(); // Clear existing goals
    playerScore = 0; // Reset player score

    if (File.Exists(filePath))
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        string name = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        int isComplete = int.Parse(parts[3]);

                        if (parts.Length == 7)
                        {
                            int completedCount = int.Parse(parts[4]);
                            int target = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);

                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                            checklistGoal.SetCompletedCount(completedCount);
                            if (isComplete == 1)
                            {
                                checklistGoal.RecordEvent(); // Mark as complete
                            }
                            goals.Add(checklistGoal);
                        }
                        else if (isComplete == 1)
                        {
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                            simpleGoal.RecordEvent(); // Mark as complete
                            goals.Add(simpleGoal);
                        }
                        else
                        {
                            EternalGoal eternalGoal = new EternalGoal(name, description, points);
                            goals.Add(eternalGoal);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading goals: " + ex.Message);
        }
    }
}
}