using System;

class HangmanGame
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            string secretWord = "hello"; // change this to the word you want to use
            int maxGuesses = 6; // change this to adjust the number of guesses allowed
            int guessesLeft = maxGuesses;
            char[] guessedLetters = new char[secretWord.Length];

            // initialize the guessedLetters array with underscores
            for (int i = 0; i < guessedLetters.Length; i++)
            {
                guessedLetters[i] = '_';
            }

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("The word has {0} letters", secretWord.Length);

            while (guessesLeft > 0 && new string(guessedLetters) != secretWord)
            {
                Console.WriteLine("Guesses left: {0}", guessesLeft);
                Console.WriteLine("Guessed letters: {0}", new string(guessedLetters));
                Console.Write("Guess a letter: ");
                char guessedLetter = Console.ReadLine()[0];

                // check if the guessed letter is in the secret word
                bool letterFound = false;
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guessedLetter)
                    {
                        guessedLetters[i] = guessedLetter;
                        letterFound = true;
                    }
                }

                if (!letterFound)
                {
                    guessesLeft--;
                    Console.WriteLine("Sorry, '{0}' is not in the word", guessedLetter);
                }
            }

            if (guessesLeft == 0)
            {
                Console.WriteLine("You lost! The word was '{0}'", secretWord);
            }
            else
            {
                Console.WriteLine("Congratulations, you won!");
            }

            Console.Write("Do you want to play again? (y/n) ");
            string playAgainInput = Console.ReadLine().ToLower();
            if (playAgainInput == "y" || playAgainInput == "yes")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
    }
}
