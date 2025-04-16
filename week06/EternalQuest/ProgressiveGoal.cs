class ProgressiveGoal : Goal
{
    private int _progress;

    public int Progress 
    { 
        get => _progress; 
        private set => _progress = value; 
    }

    public ProgressiveGoal(string name, int points) : base(name, points)
    {
        Progress = 0;
    }

    public override void RecordEvent()
    {
        Progress++;
        Console.WriteLine($"Progress increased for {Name}: {Progress}");
    }

    public override string GetProgress()
    {
        return $"Progress: {Progress} - {Name}";
    }
}
