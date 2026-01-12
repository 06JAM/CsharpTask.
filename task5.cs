using System;

class StudentReportCard
{
    static void Main()
    {
        // Get total students with validation
        int totalStudents;
        while (true)
        {
            Console.Write("Enter Total Students : ");
            if (int.TryParse(Console.ReadLine(), out totalStudents) && totalStudents > 0) break;
            Console.WriteLine("Enter valid positive number!");
        }

        // Multi-dimensional array for marks, 1D array for names
        int[,] marks = new int[totalStudents, 3];
        string[] names = new string[totalStudents];
        int[] totals = new int[totalStudents];

        // Input data
        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine("\n****************************************");
            Console.Write("Enter Student Name : ");
            names[i] = Console.ReadLine();

            // Get valid marks for each subject
            marks[i, 0] = GetValidMarks("English");
            marks[i, 1] = GetValidMarks("Math");
            marks[i, 2] = GetValidMarks("Computer");

            // Calculate total
            totals[i] = marks[i, 0] + marks[i, 1] + marks[i, 2];
        }

        // Sort indices by total (descending)
        int[] sortedIndices = new int[totalStudents];
        for (int i = 0; i < totalStudents; i++) sortedIndices[i] = i;
        for (int i = 0; i < totalStudents - 1; i++)
        {
            for (int j = 0; j < totalStudents - i - 1; j++)
            {
                if (totals[sortedIndices[j]] < totals[sortedIndices[j + 1]])
                {
                    int temp = sortedIndices[j];
                    sortedIndices[j] = sortedIndices[j + 1];
                    sortedIndices[j + 1] = temp;
                }
            }
        }

        // Assign positions and display report
        Console.WriteLine("\n********************************Report Card********************************");
        Console.WriteLine("***********************************************************************");
        for (int i = 0; i < totalStudents; i++)
        {
            int pos = i + 1;
            if (i > 0 && totals[sortedIndices[i]] == totals[sortedIndices[i - 1]])
                pos = i; // Match previous position if tie
            Console.WriteLine($"Student Name: {names[sortedIndices[i]]}, Position: {pos}, Total: {totals[sortedIndices[i]]}/300");
            Console.WriteLine("***********************************************************************");
        }
    }

    // Get valid 0-100 marks
    static int GetValidMarks(string sub)
    {
        int mark;
        while (true)
        {
            Console.Write($"Enter {sub} Marks (0-100) : ");
            if (int.TryParse(Console.ReadLine(), out mark) && mark >= 0 && mark <= 100) break;
            Console.WriteLine("Enter valid number 0-100!");
        }
        return mark;
    }
}
