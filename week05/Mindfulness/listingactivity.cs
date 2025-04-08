class ListingActivity : MindfulnessActivity
{
    private List<string> Prompts = new List<string>
    {
        "List people you appreciate.",
        "List personal strengths."
    };

    public override void PerformActivity()
    {
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
