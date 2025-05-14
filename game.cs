
using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guess;
            int attempts = 0;
            bool isCorrect = false;

            Console.WriteLine("🎯 Welcome to the Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");
            Console.WriteLine();

            // Game loop
            while (!isCorrect)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Validate input
                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    if (guess == secretNumber)
                    {
                        Console.WriteLine($"✅ Congratulations! You guessed the number in {attempts} attempts.");
                        isCorrect = true;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("📉 Too low. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("📈 Too high. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("⚠️ Invalid input. Please enter a number between 1 and 100.");
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
