using System;
using System.Collections.Generic;

class Program
{
    // I Add additional kinds of goals, such as the ability to make progress towards a large goal 
    // and negative goals where they lose points for bad habits.
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public int Score 
    { 
        get => _score; 
        private set => _score = value; 
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public Goal CreateGoal(string type, string name, int points, int target = 0, int bonus = 0)
    {
        return type switch
        {
            "1" => new SimpleGoal(name, points),
            "2" => new EternalGoal(name, points),
            "3" => new ChecklistGoal(name, points, target, bonus),
            "4" => new ProgressiveGoal(name, points),
            "5" => new NegativeGoal(name, points),
            _ => throw new ArgumentException("Invalid selection")
        };
    }


   public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name == goalName) // Use the Name property instead of GetName()
            {
                goal.RecordEvent();
                Score += goal.Points;
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted())
                {
                    Score += checklistGoal.BonusPoints;
                }
                return;
            }
        }
        Console.WriteLine("Goal not found!");
    }


    public void DisplayAnimatedProgress(string message)
    {
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{goal.GetProgress()} | {goal.Name}"); // Use Name property
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {Score}");
    }

    static void Main()
    {
        Program program = new Program();

        program.AddGoal(new SimpleGoal("Run a marathon", 1000));
        program.AddGoal(new EternalGoal("Read scriptures", 100));
        program.AddGoal(new ChecklistGoal("Attend the temple", 50, 10, 500));

        program.RecordEvent("Read scriptures");
        program.RecordEvent("Attend the temple");
        program.RecordEvent("Attend the temple");
        program.DisplayGoals();
        program.DisplayScore();
    }
}
