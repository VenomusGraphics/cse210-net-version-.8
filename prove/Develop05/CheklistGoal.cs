public class ChecklistGoal : Goal
{
    private int completedCount;
    private int target;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        this.target = target;
        this.bonus = bonus;
        completedCount = 0;
    }

    public void SetCompletedCount(int count)
    {
        completedCount = count;
    }

    public override int RecordEvent()
    {
        if (completedCount < target)
        {
            completedCount++;
            if (completedCount == target)
            {
                return points + bonus;
            }
            return points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return completedCount == target;
    }

    public override string GetDetailsString()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {name} - {description} ({completedCount}/{target})";
    }

    public override string GetStringRepresentation()
    {
        return $"{name},{description},{points},{(IsComplete() ? "1" : "0")},{completedCount},{target},{bonus}";
    }
}