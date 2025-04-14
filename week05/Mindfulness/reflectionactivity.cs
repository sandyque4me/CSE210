using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ReflectionActivity : MindfulnessActivity
    {
        private static int _performanceCount;
        private List<string> _prompts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult."
        };
        private List<string> _questions = new()
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?"
        };

        public static int PerformanceCount => _performanceCount;

        public override void PerformActivity()
        {
            _performanceCount++;
            Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
            DateTime start = DateTime.Now;

            while ((DateTime.Now - start).Seconds < _duration)
            {
                Console.WriteLine(_questions[new Random().Next(_questions.Count)]);
                ShowAnimation();
            }
        }
    }
}