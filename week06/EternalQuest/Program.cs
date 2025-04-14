using System;
using System.Collections.Generic;

class Program
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.RecordEvent();
                score += goal.GetPoints();
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted())
                {
                    score += checklistGoal.GetBonusPoints();
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
            System.Threading.Thread.Sleep(100); // Delay for animation
        }
        Console.WriteLine();
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetProgress()} {goal.GetName()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
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