class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public int TargetCount 
    { 
        get => _targetCount; 
        private set => _targetCount = value; 
    }
    public int CurrentCount 
    { 
        get => _currentCount; 
        private set => _currentCount = value; 
    }
    public int BonusPoints 
    { 
        get => _bonusPoints; 
        private set => _bonusPoints = value; 
    }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public bool IsCompleted() => CurrentCount >= TargetCount;

    public override void RecordEvent()
    {
        if (!IsCompleted())
        {
            CurrentCount++;
            Console.WriteLine($"Event recorded for {Name}. Progress: {CurrentCount}/{TargetCount}");
        }
        else
        {
            Console.WriteLine($"{Name} has already been completed!");
        }
    }

    public override string GetProgress()
    {
        return $"Progress: {CurrentCount}/{TargetCount} - {Name}";
    }
}
