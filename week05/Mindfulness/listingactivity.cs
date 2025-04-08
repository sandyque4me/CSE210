class ListingActivity : MindfulnessActivity
{
    public static int PerformanceCount = 0;

    private List<string> Prompts = new List<string>
    {
        "List people you appreciate.",
        "List personal strengths."
    };

    public override void PerformActivity()
    {
        PerformanceCount++; // Increment counter
        Console.WriteLine(Prompts[new Random().Next(Prompts.Count)]);
        Console.WriteLine("Start listing items:");
        int count = 0;

        while (count < Duration)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items.");
    }
}
