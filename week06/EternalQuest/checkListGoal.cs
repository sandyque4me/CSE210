using System;

class ChecklistGoal : Goal
{
    private int requiredCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int requiredCount, int bonusPoints)
        : base(name, points)
    {
        this.requiredCount = requiredCount;
        this.currentCount = 0;
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        currentCount++;
    }

    public override bool IsCompleted()
    {
        return currentCount >= requiredCount;
    }

    public override string GetProgress()
    {
        return $"Completed {currentCount}/{requiredCount} times";
    }

    public int GetBonusPoints()
    {
        return IsCompleted() ? bonusPoints : 0;
    }
}

