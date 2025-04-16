
class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Event recorded for {Name}");
    }

    public override string GetProgress()
    {
        return $"Completed: {Name}";
    }
}
