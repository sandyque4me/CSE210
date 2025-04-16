class NegativeGoal : Goal
{
    public NegativeGoal(string name, int points) : base(name, -Math.Abs(points)) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Negative event recorded for {Name}");
    }

    public override string GetProgress()
    {
        return $"Penalty: {Name}";
    }
}
