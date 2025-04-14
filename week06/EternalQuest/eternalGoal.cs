using System;

class EternalGoal : Goal
{
    private int recordCount;

    public EternalGoal(string name, int points) : base(name, points)
    {
        recordCount = 0;
    }

    public override void RecordEvent()
    {
        recordCount++;
    }

    public override bool IsCompleted()
    {
        return false; // Eternal goals are never completed
    }

    public override string GetProgress()
    {
        return $"Recorded {recordCount} times";
    }
}