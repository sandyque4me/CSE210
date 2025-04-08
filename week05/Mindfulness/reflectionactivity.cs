class ReflectionActivity : MindfulnessActivity
{
    public static int PerformanceCount = 0;

    private List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult."
    };

    private List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?"
    };

    public override void PerformActivity()
    {
        PerformanceCount++; // Increment counter
        Console.WriteLine(Prompts[new Random().Next(Prompts.Count)]);
        for (int i = 0; i < Duration / 3; i++)
        {
            Console.WriteLine(Questions[new Random().Next(Questions.Count)]);
            ShowAnimation();
        }
    }
}
