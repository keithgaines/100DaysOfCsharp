using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the plaintext message from the user
            Console.WriteLine("Enter the message you want to encrypt or decrypt: ");
            string message = Console.ReadLine();

            // Get the encryption key from the user
            Console.WriteLine("Enter the encryption/decryption key (a positive integer): ");
            int key = int.Parse(Console.ReadLine());

            // Determine if the user wants to encrypt or decrypt the message
            Console.WriteLine("Do you want to encrypt or decrypt the message? Enter E for encrypt or D for decrypt: ");
            string mode = Console.ReadLine().ToUpper();

            // Convert the message to uppercase for simplicity
            message = message.ToUpper();

            // Create a string to hold the result
            string result = "";

            // Determine the shift based on the encryption/decryption key and mode
            int shift = mode == "E" ? key : 26 - key;

            // Iterate through each character in the message
            foreach (char c in message)
            {
                // If the character is a letter, shift it by the appropriate amount
                if (Char.IsLetter(c))
                {
                    char shiftedChar = (char)(((int)c + shift - 65) % 26 + 65);
                    result += shiftedChar;
                }
                // If the character is not a letter, leave it unchanged
                else
                {
                    result += c;
                }
            }

            // Print the result
            if (mode == "E")
            {
                Console.WriteLine("The encrypted message is: " + result);
            }
            else if (mode == "D")
            {
                Console.WriteLine("The decrypted message is: " + result);
            }
            else
            {
                Console.WriteLine("Invalid mode. Please enter E for encrypt or D for decrypt.");
            }
        }
    }
}
