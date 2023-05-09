# FizzBuzz

FizzBuzz is a classic programming exercise used to teach programming fundamentals. It prints the numbers 1 to 100, but replaces multiples of 3 with "Fizz", multiples of 5 with "Buzz", and multiples of both 3 and 5 with "FizzBuzz".

## How to Build and Run

1. Save the following code to a file called "FizzBuzz.cs":

```csharp
using System;

class Program {
    static void Main(string[] args) {
        for (int i = 1; i <= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0) {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0) {
                Console.WriteLine("Buzz");
            }
            else {
                Console.WriteLine(i);
            }
        }
    }
}
```

2. Compile the code using the C# compiler.
3. Run the executable using the following command in the terminal: 

```sh
./FizzBuzz.exe
```

The output will be the numbers 1 to 100, with "Fizz" replacing multiples of 3, "Buzz" replacing multiples of 5, and "FizzBuzz" replacing multiples of both 3 and 5.

