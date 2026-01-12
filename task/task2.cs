using System;

namespace ArrayTask
{
    class Task2
    {
        static void Main(string[] args)
        {
            // Create and fill a jagged 2D array
            int[][] numberMatrix = new int[][]
            {
                new int[] { 2, 4, 6, 8, 10 },  // even numbers
                new int[] { 1, 3, 5, 7, 9 }    // odd numbers
            };

            Console.WriteLine("The number matrix has been initialized.\n");

            // Get the digits from the array
            int digit1 = numberMatrix[1][3]; // Index 3
            int digit2 = numberMatrix[0][0]; // Index 0
            int digit3 = numberMatrix[1][4]; // Index 4

            // Combine the digits into one string
            string finalKey = $"{digit1}{digit2}{digit3}";

            // Show the result output: 729
            Console.WriteLine($"Digits: {digit1}, {digit2}, {digit3}");
            Console.WriteLine($"Password: {finalKey}");
        }
    }
}
