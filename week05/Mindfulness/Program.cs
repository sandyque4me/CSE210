class Program
{
    // I Kept a log of how many times activities were performed in this program.
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an option:\n1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. View Log\n5. Exit");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 5) break;

            MindfulnessActivity activity = choice switch
            {
                1 => new BreathingActivity { Name = "Breathing Activity", Description = "This activity will help you relax by guiding you through slow breathing." },
                2 => new ReflectionActivity { Name = "Reflection Activity", Description = "This activity will help you reflect on times you have shown strength and resilience." },
                3 => new ListingActivity { Name = "Listing Activity", Description = "This activity will help you reflect on the good things in your life by listing as many items as you can." },
                4 => null, // Option to view log
                _ => throw new Exception("Invalid choice!")
            };

            if (choice == 4)
            {
                MindfulnessActivity.DisplayLog(); // View log
                continue;
            }

            activity.StartActivity();
            activity.PerformActivity();
            activity.EndActivity();
        }

        Console.WriteLine("Thank you for using the Mindfulness App!");
    }
}
