using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Welcome to the program!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int favoriteNumber;

        if (int.TryParse(input, out favoriteNumber))
        {
            int square = favoriteNumber * favoriteNumber;
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        else
        {
            Console.WriteLine("Invalid number entered.");
        }
    }
}