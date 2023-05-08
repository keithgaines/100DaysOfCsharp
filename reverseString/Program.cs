using System;
using System.Collections.Generic;
using System.Linq;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text to reverse: ");
            string input = Console.ReadLine();
            List<char> charList = input.ToList();

            List<char> reversedChars = new List<char>();
            for (int i = charList.Count - 1; i >= 0; i--)
            {
                reversedChars.Add(charList[i]);
            }

            string output = string.Join("", reversedChars);
            Console.WriteLine("The reversed text is: ");
            Console.WriteLine(output);
        }

    }
}
