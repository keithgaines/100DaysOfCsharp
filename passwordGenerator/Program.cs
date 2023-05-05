using System;
using System.Collections.Generic;

class PasswordGenerator
{
    static void Main()
    {
        // creates the lists "letters," "numbers," and "symbols"
        List<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
           'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
           'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        List<char> symbols = new List<char> { '!', '#', '$', '%', '&', '(', ')', '*', '+' };

        Console.WriteLine("Welcome to the Password Generator!");
        Console.Write("How many letters would you like in your password? ");
        int nr_letters = int.Parse(Console.ReadLine());
        Console.Write("How many symbols would you like? ");
        int nr_symbols = int.Parse(Console.ReadLine());
        Console.Write("How many numbers would you like? ");
        int nr_numbers = int.Parse(Console.ReadLine());

        // Standard Pattern (order not randomized)
        string password = "";

    }
}