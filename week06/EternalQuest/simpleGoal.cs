using System;

class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        isCompleted = false;
    }

    public override void RecordEvent()
    {
        isCompleted = true;
    }

    public override bool IsCompleted()
    {
        return isCompleted;
    }

    public override string GetProgress()
    {
        return isCompleted ? "[X]" : "[ ]";
    }
}