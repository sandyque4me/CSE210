using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select an activity:\n1. Breathing\n2. Reflection\n3. Listing");
        int choice = int.Parse(Console.ReadLine());

        MindfulnessActivity activity = choice switch
        {
            1 => new BreathingActivity(),
            2 => new ReflectionActivity(),
            3 => new ListingActivity(),
            _ => throw new Exception("Invalid choice!")
        };

        activity.StartActivity();
        activity.PerformActivity();
        activity.EndActivity();
    }
}
