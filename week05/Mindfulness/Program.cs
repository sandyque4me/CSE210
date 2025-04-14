using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> activityLog = new()
            {
                { "Breathing Activity", 0 },
                { "Reflection Activity", 0 },
                { "Listing Activity", 0 }
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. View Log");
                Console.WriteLine("5. Exit");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5) break;

                MindfulnessActivity activity = choice switch
                {
                    1 => new BreathingActivity(),
                    2 => new ReflectionActivity(),
                    3 => new ListingActivity(),
                    _ => throw new Exception("Invalid choice!")
                };

                if (choice == 4)
                {
                    MindfulnessActivity.DisplayLog(activityLog);
                    continue;
                }

                activity.StartActivity();
                activity.PerformActivity();
                activity.EndActivity();

                string activityName = choice switch
                {
                    1 => "Breathing Activity",
                    2 => "Reflection Activity",
                    3 => "Listing Activity",
                    _ => throw new Exception("Invalid activity!")
                };

                activityLog[activityName]++;
            }

            Console.WriteLine("Thank you for using the Mindfulness App!");
        }
    }
}