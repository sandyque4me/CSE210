using System;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        private static int _performanceCount;

        public static int PerformanceCount => _performanceCount;

        public override void PerformActivity()
        {
            _performanceCount++;
            for (int i = 0; i < _duration / 2; i++)
            {
                Console.WriteLine("Breathe in...");
                ShowAnimation();
                Console.WriteLine("Breathe out...");
                ShowAnimation();
            }
        }
    }
}