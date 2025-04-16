using System;

abstract class Goal
{
    // I Add additional kinds of goals, such as the ability to make progress towards a large goal 
    // and negative goals where they lose points for bad habits.

    private string _name;
    private int _points;

    public string Name 
    { 
        get => _name; 
        private set => _name = value; 
    }
    public int Points 
    { 
        get => _points; 
        protected set => _points = value; 
    }

    protected Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract string GetProgress();
}
