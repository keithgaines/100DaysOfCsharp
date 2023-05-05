using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Password Generator Project
        Random random = new Random();

        // creates the lists "letters," "numbers," and "symbols"
        List<char> letters = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        List<char> symbols = new List<char> { '!', '#', '$', '%', '&', '(', ')', '*', '+' };

        Console.WriteLine("Welcome to the PyPassword Generator!");
        Console.Write("How many letters would you like in your password? ");
        int nr_letters = int.Parse(Console.ReadLine());
        Console.Write("How many symbols would you like? ");
        int nr_symbols = int.Parse(Console.ReadLine());
        Console.Write("How many numbers would you like? ");
        int nr_numbers = int.Parse(Console.ReadLine());

        // Standard Pattern (order not randomized)
        List<char> password_list = new List<char>();

        // for character in range from 1 - user input number of how many characters they want+1
        // add randomly selected character from list to the end of the password list
        for (int i = 1; i <= nr_letters; i++)
        {
            password_list.Add(letters[random.Next(letters.Count)]);
        }

        for (int i = 1; i <= nr_symbols; i++)
        {
            password_list.Add(symbols[random.Next(symbols.Count)]);
        }

        for (int i = 1; i <= nr_numbers; i++)
        {
            password_list.Add(numbers[random.Next(numbers.Count)]);
        }

        // shuffles the password_list list
        password_list = password_list.OrderBy(x => random.Next()).ToList();

        // creates a blank string called password
        string password = "";

        // adds shuffled items from password_list to the password string
        foreach (char c in password_list)
        {
            password += c;
        }

        // prints the completed password string
        Console.WriteLine("Your password is: " + password);
    }
}
