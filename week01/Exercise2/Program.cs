using System;

class Program
{
    static void Main(string[] args)
    {
        // I added "level"" variable to indicate sign(+/-)
        Console.WriteLine("What is your grade percentage?");
        string userInpute = Console.ReadLine();
        int percent = int.Parse(userInpute);

        string letter = "";
        int lastDigit = 0;
        string level = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        lastDigit = percent % 10;


        if (lastDigit >= 7)
        {
            level = "+";
        }
        else if (lastDigit < 3)
        {
            level = "-";
        }
        else
        {
            level = "";
        }

        {
            Console.Write($"Your grade is: {letter}{level}. ");
        }

        if (percent >= 70)
        {
            Console.WriteLine("Congratulation! You passed!");
        }
        else
        {
            Console.WriteLine("You can do better next time!");
        }
    }
}
