using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : MindfulnessActivity
    {
        private static int _performanceCount;
        private List<string> _prompts = new()
        {
            "List people you appreciate.",
            "List personal strengths."
        };

        public static int PerformanceCount => _performanceCount;

        public override void PerformActivity()
        {
            _performanceCount++;
            Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
            Console.WriteLine("Start listing items:");
            int count = 0;

            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).Seconds < _duration)
            {
                Console.Write("> ");
                Console.ReadLine();
                count++;
            }

            Console.WriteLine($"You listed {count} items.");
        }
    }
}