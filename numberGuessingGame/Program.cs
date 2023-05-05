using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        Console.Write("Choose a difficulty. Type 'easy' or 'hard': ");
        string difficulty = Console.ReadLine();

        // chooses a random number from a range of 1 - 100 cast as an integer
        Random random = new Random();
        int chosen_number = random.Next(1, 100);

        // if statement that assigns number of attempts based on difficulty
        int attempts = difficulty == "easy" ? 10 : 5;
        Console.WriteLine($"You have {attempts} attempts remaining to guess the number.");

        // assigns user guess to variable 'guess' and casts it as an int from a string
        Console.Write("Make a guess: ");
        int guess = int.Parse(Console.ReadLine());

        while (attempts > 0)
        {
            if (guess > chosen_number)
            {
                Console.Write("Too high. Guess again: ");
                guess = int.Parse(Console.ReadLine());
                attempts--;
            }
            else if (guess < chosen_number)
            {
                Console.Write("Too low. Guess again: ");
                guess = int.Parse(Console.ReadLine());
                attempts--;
            }
            else
            {
                Console.WriteLine("You guessed it");
                attempts = 0;
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine($"The correct number was {chosen_number}. Game over");
            Console.ReadLine();
        }
    }
}
