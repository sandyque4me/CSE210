class MindfulnessActivity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {Name}:\n{Description}");
        Console.Write("Enter duration (seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowAnimation();
    }

    public virtual void PerformActivity()
    {
        Console.WriteLine("This is a generic activity. Override this method in derived classes.");
    }

    public virtual void EndActivity()
    {
        Console.WriteLine($"Good job! You completed {Name} for {Duration} seconds.");
        ShowAnimation();
    }

    public void ShowAnimation()
    {
        Console.WriteLine("Animation:...");
        System.Threading.Thread.Sleep(3000); // Simulate animation
    }

    public static void DisplayLog()
    {
        Console.WriteLine("\nActivity Performance Log:");
        Console.WriteLine($"Breathing Activity: {BreathingActivity.PerformanceCount} times");
        Console.WriteLine($"Reflection Activity: {ReflectionActivity.PerformanceCount} times");
        Console.WriteLine($"Listing Activity: {ListingActivity.PerformanceCount} times\n");
    }
}
