using System;

abstract class Goal
{
    private string name;
    private int points;

    protected Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public string GetName()
    {
        return name;
    }

    public int GetPoints()
    {
        return points;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public abstract string GetProgress();
}