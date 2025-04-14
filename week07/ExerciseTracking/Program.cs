using System;
using System.Collections.Generic;

namespace FitnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            var activities = new List<Activity>
            {
                new Running(new DateTime(2023, 11, 3), 30, 4.8),
                new Cycling(new DateTime(2023, 11, 3), 45, 25),
                new Swimming(new DateTime(2023, 11, 3), 20, 30)
            };

            // Display summaries
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}