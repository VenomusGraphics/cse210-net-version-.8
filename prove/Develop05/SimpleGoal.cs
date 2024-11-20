public class SimpleGoal : Goal
{
    private bool isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
            return points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{(isComplete ? "[X]" : "[ ]")} {name} - {description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{name},{description},{points},{(isComplete ? "1" : "0")}";
    }
}
