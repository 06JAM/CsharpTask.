using System;

// Application namespace and class
class Task3
{
    static void Main()
    {
        // Initialize the target array
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };
        
        // User input section with validation
        Console.WriteLine("=== Number Search Program ===");
        Console.Write("Enter a number to search for: ");
        string input = Console.ReadLine();
        
        // Check if input is a valid integer
        if (!int.TryParse(input, out int searchNumber))
        {
            Console.WriteLine("Invalid input! Please enter a whole number.");
            return;
        }
        
        // Search logic with for loop
        int arrayLength = numbers.Length;
        bool isFound = false;
        
        for (int index = 0; index < arrayLength; index++)
        {
            if (numbers[index] == searchNumber)
            {
                Console.WriteLine($"Number found at position {index}!");
                isFound = true;
                break; // Terminate loop on match
            }
        }
        
        // Message if no match found
        if (!isFound)
        {
            Console.WriteLine("Number not found in the list.");
        }
    }
}