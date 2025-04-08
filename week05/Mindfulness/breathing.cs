class BreathingActivity : MindfulnessActivity
{
    public static int PerformanceCount = 0;

    public override void PerformActivity()
    {
        PerformanceCount++; // Increment counter
        for (int i = 0; i < Duration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowAnimation();
            Console.WriteLine("Breathe out...");
            ShowAnimation();
        }
    }
}
