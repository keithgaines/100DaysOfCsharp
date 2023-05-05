using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Band Name Generator.");

        Console.WriteLine("What's the name of the city you grew up in?");
        string city = Console.ReadLine();

        Console.WriteLine("What's the name of your pet?");
        string pet = Console.ReadLine();

        Console.WriteLine("Your band name could be " + city + " " + pet);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
