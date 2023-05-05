using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the tip calculator");

        // prompt the user for input
        Console.Write("What was the total bill? ");
        float total_bill = float.Parse(Console.ReadLine());

        Console.Write("What percentage tip would you like to give? 10, 12, or 15? ");
        float tip_percentage = float.Parse(Console.ReadLine());

        Console.Write("How many people to split the bill? ");
        float split_ways = float.Parse(Console.ReadLine());

        // calculates the total amount each person owes
        float result = (total_bill / split_ways) * ((tip_percentage / 100) + 1);

        // prints result rounded to 2 decimal places
        Console.WriteLine("Each person owes: " + Math.Round(result, 2));
    }
}
