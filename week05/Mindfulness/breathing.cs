class BreathingActivity : MindfulnessActivity
{
    public override void PerformActivity()
    {
        for (int i = 0; i < Duration / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowAnimation();
            Console.WriteLine("Breathe out...");
            ShowAnimation();
        }
    }
}
