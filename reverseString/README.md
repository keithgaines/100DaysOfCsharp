# Reverse a String - C# Console Application

This is a simple C# console application that reads a string from the user, reverses its characters, and prints the reversed string to the console. The program uses the `System` and `System.Collections.Generic` namespaces to work with strings and lists.

## How to Run the Program

To run the program, follow these steps:

1. Open Visual Studio or another C# development environment.
2. Create a new console application project.
3. Copy and paste the code from this file into your project.
4. Build and run the project.

## How the Program Works

1. The program prompts the user to enter a string to reverse, using the `Console.WriteLine` method to display a message in the console.
2. The program reads the user's input from the console using the `Console.ReadLine` method and stores it in a string variable named `input`.
3. The program converts the input string to a list of characters using the `ToList` method of the `string` class, which returns a `List<char>` object.
4. The program creates an empty `List<char>` object named `reversedChars` to store the reversed characters.
5. The program uses a `for` loop to iterate through the characters in the input string in reverse order, starting from the last character and ending at the first character. Inside the loop, it adds each character to the `reversedChars` list using the `Add` method.
6. After the loop completes, the program uses the `string.Join` method to concatenate the characters in the `reversedChars` list into a single string, with no separator between the characters.
7. The program uses the `Console.WriteLine` method to display a message in the console indicating that the reversed text is about to be displayed.
8. The program uses the `Console.WriteLine` method again to display the reversed string in the console.

## Example Output

```
Please enter text to reverse:
hello world
The reversed text is:
dlrow olleh
```

In this example, the user enters the text "hello world". The program reverses the characters of the input string and displays the reversed text "dlrow olleh" in the console.