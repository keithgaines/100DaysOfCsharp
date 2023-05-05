using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;

            Console.WriteLine("Welcome to the Calculator program!");

            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: division by zero.");
                        return;
                    }
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Error: invalid operation.");
                    return;
            }

            Console.WriteLine("Result: " + result);

            // allow user to perform operations on the result with a new number
            while (true)
            {
                Console.Write("Enter the operation (+, -, *, /) to perform on the result or 'q' to quit: ");
                operation = Convert.ToChar(Console.ReadLine());

                if (operation == 'q')
                {
                    Console.WriteLine("Exiting program...");
                    return;
                }

                Console.Write("Enter the next number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        result += num2;
                        break;

                    case '-':
                        result -= num2;
                        break;

                    case '*':
                        result *= num2;
                        break;

                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: division by zero.");
                            return;
                        }
                        result /= num2;
                        break;

                    default:
                        Console.WriteLine("Error: invalid operation.");
                        return;
                }

                Console.WriteLine("Result: " + result);
            }
        }
    }
}
