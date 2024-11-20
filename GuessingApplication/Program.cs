using System;
using GuessingApplication.Controllers;
using GuessingApplication.Models;

namespace GuessingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameController = new GuessAppController();
            bool correctGuess = false;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            while (!correctGuess)
            {
                Console.Write("Please enter your guess (between 1 and 100): ");
                string userInput = Console.ReadLine();
                int guess;

                if (int.TryParse(userInput, out guess))
                {
                    string result = gameController.MakeGuess(guess);
                    Console.WriteLine(result);

                    if (result == "Congratulations, You guessed it!")
                    {
                        correctGuess = true;
                        Console.WriteLine("Here are your guess attempts:");

                        var guessHistory = gameController.GetGuessHistory();
                        foreach (var record in guessHistory)
                        {
                            Console.WriteLine($"{record.GuessTime}: You guessed {record.PlayerGuess} and the result was: {record.GuessFeedback}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
