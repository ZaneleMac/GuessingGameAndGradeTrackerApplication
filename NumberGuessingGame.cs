using System;

public class NumberGuessingGame
{
    public void Play()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101); // Number between 1 and 100
        int maxTries = 5;
        int currentTry = 0;

        Console.WriteLine("\n--- Number Guessing Game ---");
        Console.WriteLine("I have picked a number between 1 and 100. You have 5 tries!");

        while (currentTry < maxTries)
        {
            Console.Write($"\nAttempt {currentTry + 1} of {maxTries}. Enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                continue;
            }

            currentTry++;

            if (guess == targetNumber)
            {
                Console.WriteLine($"🎉 Correct! You guessed the number in {currentTry} tries.");
                return;
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("Too high!");
            }
        }

        Console.WriteLine($"\nGame Over! The correct number was {targetNumber}.");
    }
}
