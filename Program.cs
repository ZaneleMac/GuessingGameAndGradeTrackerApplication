using System;

class Program
{
    static void Main(string[] args)
    {
        NumberGuessingGame guessingGame = new NumberGuessingGame();
        GradeTracker gradeTracker = new GradeTracker();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("      Game And Tracker Application ");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Play Number Guessing Game");
            Console.WriteLine("2. Run Student Grade Tracker");
            Console.WriteLine("3. Exit");
            Console.Write("\nSelect an option (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    guessingGame.Play();
                    break;
                case "2":
                    gradeTracker.RunTracker();
                    break;
                case "3":
                    running = false;
                    Console.WriteLine("\nExiting application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Press any key to try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}