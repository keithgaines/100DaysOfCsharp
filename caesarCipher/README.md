# Caesar Cipher

This is a simple implementation of the Caesar Cipher encryption algorithm in C#. The program prompts the user to enter a message, an encryption/decryption key, and a mode (either "E" for encrypt or "D" for decrypt), and then applies the appropriate shift to each letter in the message to produce an encrypted or decrypted message.

## Getting Started

To use this program, simply clone the repository or download the source code and open it in Visual Studio or another C# development environment. Then run the program and follow the on-screen prompts to encrypt or decrypt a message.

## Usage

To encrypt a message, follow these steps:

1. Enter the plaintext message you want to encrypt when prompted.
2. Enter a positive integer for the encryption key when prompted.
3. Enter "E" when prompted to select the encryption mode.
4. The program will apply the appropriate shift to each letter in the message and display the resulting ciphertext.

To decrypt a message, follow these steps:

1. Enter the ciphertext message you want to decrypt when prompted.
2. Enter the same positive integer you used to encrypt the message for the decryption key when prompted.
3. Enter "D" when prompted to select the decryption mode.
4. The program will apply the appropriate shift to each letter in the message and display the resulting plaintext.


## Acknowledgments

This program is based on the Caesar Cipher algorithm, which is one of the simplest and oldest methods of encryption. It was used by Julius Caesar to encode his messages during wartime, and involves shifting each letter in the plaintext message by a certain number of positions in the alphabet. The Caesar Cipher is easy to understand and implement, but is vulnerable to various forms of cryptanalysis, such as frequency analysis.