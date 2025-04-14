using System;
using System.Threading;

namespace MindfulnessApp
{
    public class MindfulnessActivity
    {
        private string _name;
        private string _description;
        protected int _duration;

        public void StartActivity()
        {
            Console.Clear();
            Console.WriteLine($"Starting {_name}:\n{_description}");
            Console.Write("Enter duration (seconds): ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowAnimation();
        }

        public virtual void PerformActivity()
        {
            Console.WriteLine("This is a generic activity. Override this method in derived classes.");
        }

        public void EndActivity()
        {
            Console.WriteLine($"Well done! You completed {_name} for {_duration} seconds.");
            ShowAnimation();
        }

        public void ShowAnimation()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }

        public static void DisplayLog(Dictionary<string, int> activityLog)
        {
            Console.WriteLine("\nActivity Performance Log:");
            foreach (var entry in activityLog)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} times");
            }
            Console.WriteLine();
        }
    }
}