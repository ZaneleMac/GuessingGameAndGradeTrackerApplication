using System;
using System.Linq;

public class GradeTracker
{
    private double[] scores;
    private int studentCount;

    public void RunTracker()
    {
        Console.Write("\nEnter the number of students to track: ");
        if (!int.TryParse(Console.ReadLine(), out studentCount) || studentCount <= 0)
        {
            Console.WriteLine("Invalid student count. Returning to main menu.");
            return;
        }

        scores = new double[studentCount];

        for (int i = 0; i < studentCount; i++)
        {
            while (true)
            {
                Console.Write($"Enter score for student {i + 1} (0 - 100): ");
                if (double.TryParse(Console.ReadLine(), out double score) && score >= 0 && score <= 100)
                {
                    scores[i] = score;
                    break;
                }
                Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
            }
        }

        DisplayResults();
    }

    private void DisplayResults()
    {
        double highest = scores.Max();
        double lowest = scores.Min();
        double average = scores.Average();

        Console.WriteLine("\n--- Grade Tracker Results ---");
        Console.WriteLine($"Average Score: {average:F2}%");
        Console.WriteLine($"Highest Score: {highest}%");
        Console.WriteLine($"Lowest Score: {lowest}%");

        Console.WriteLine("\nIndividual Grades:");
        for (int i = 0; i < scores.Length; i++)
        {
            char letterGrade = CalculateLetterGrade(scores[i]);
            Console.WriteLine($"Student {i + 1}: {scores[i]}% [{letterGrade}]");
        }
    }

    private char CalculateLetterGrade(double score)
    {
        if (score >= 75) return 'A';
        if (score >= 60) return 'B';
        if (score >= 50) return 'C';
        if (score >= 40) return 'D';
        return 'F';
    }
}