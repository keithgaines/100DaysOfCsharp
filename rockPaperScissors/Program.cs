using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        while (play == true) // added parentheses and double equal sign to fix syntax error
        {
            // Array of possible choices
            string[] choices = { "rock", "paper", "scissors" };

            // Get user's choice
            Console.WriteLine("Choose rock, paper, or scissors:");
            string userChoice = Console.ReadLine().ToLower();

            // Generate random computer choice
            Random random = new Random();
            int computerIndex = random.Next(choices.Length);
            string computerChoice = choices[computerIndex];

            // Display choices
            Console.WriteLine("You chose: " + userChoice);
            Console.WriteLine("Computer chose: " + computerChoice);

            // Determine winner
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (userChoice == "rock" && computerChoice == "scissors" ||
                userChoice == "paper" && computerChoice == "rock" ||
                userChoice == "scissors" && computerChoice == "paper")
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }

            Console.WriteLine("Do you want to play again? y or n"); // corrected single quotes to double quotes
            // Wait for user input before closing
            string playAgain = Console.ReadLine();
            if (playAgain == "y") // corrected single quotes to double quotes and added double equal sign
            {
                play = true;
            }
            else if (playAgain == "n") // corrected single quotes to double quotes and added else if statement
            {
                play = false;
            }
        }
    }
}
 