using System;

/// <summary>
/// A menu-driven arithmetic calculator that supports addition, subtraction, multiplication, and division.
/// Allows repeated use until the user chooses to exit.
/// </summary>
class Task4
{
    static void Main()
    {
        bool continueCalculating = true;

        // Main loop to repeat calculator sequence
        while (continueCalculating)
        {
            // Display menu and get operation choice
            Console.WriteLine("\n=== Arithmetic Calculator ===");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.Write("Select an operation (1-4): ");
            string operationInput = Console.ReadLine();

            // Get and validate two numerical inputs
            double value1 = GetValidNumberInput("Enter Value 1: ");
            double value2 = GetValidNumberInput("Enter Value 2: ");

            // Route to appropriate operation using switch-case
            switch (operationInput)
            {
                case "1":
                    double sum = Add(value1, value2);
                    Console.WriteLine($"{value1} + {value2} = {sum}");
                    break;
                case "2":
                    double difference = Subtract(value1, value2);
                    Console.WriteLine($"{value1} - {value2} = {difference}");
                    break;
                case "3":
                    double product = Multiply(value1, value2);
                    Console.WriteLine($"{value1} * {value2} = {product}");
                    break;
                case "4":
                    // Handle division by zero
                    if (value2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    else
                    {
                        double quotient = Divide(value1, value2);
                        Console.WriteLine($"{value1} / {value2} = {quotient}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selection. Please choose 1-4.");
                    break;
            }

            // Prompt user to continue or exit
            Console.Write("\nDo you want to perform another calculation? (Y/N): ");
            string continueInput = Console.ReadLine().Trim().ToUpper();
            continueCalculating = (continueInput == "Y");
        }

        Console.WriteLine("Thank you for using the calculator! Goodbye.");
    }

    /// <summary>
    /// Prompts the user for a number and returns a valid double.
    /// </summary>
    /// <param name="prompt">Message to display to the user.</param>
    /// <returns>Validated numerical input.</returns>
    static double GetValidNumberInput(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
            {
                return number;
            }
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }

    /// <summary>
    /// Performs addition of two numbers.
    /// </summary>
    /// <param name="a">First number.</param>
    /// <param name="b">Second number.</param>
    /// <returns>Sum of a and b.</returns>
    static double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Performs subtraction of two numbers.
    /// </summary>
    /// <param name="a">Minuend.</param>
    /// <param name="b">Subtrahend.</param>
    /// <returns>Difference of a and b.</returns>
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Performs multiplication of two numbers.
    /// </summary>
    /// <param name="a">First factor.</param>
    /// <param name="b">Second factor.</param>
    /// <returns>Product of a and b.</returns>
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// Performs division of two numbers.
    /// </summary>
    /// <param name="a">Dividend.</param>
    /// <param name="b">Divisor (must not be zero).</param>
    /// <returns>Quotient of a and b.</returns>
    static double Divide(double a, double b)
    {
        return a / b;
    }
}
