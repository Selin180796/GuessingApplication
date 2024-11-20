using System;
using GuessingApplication.Data;
using GuessingApplication.Models;

namespace GuessingApplication.Controllers
{
    public class GuessAppController
    {
        private int target_Number;
        private GuessAppData guess_Data;

        public GuessAppController()
        {
            guess_Data = new GuessAppData();
            Random random = new Random();
            target_Number = random.Next(1, 101); 
        }

        public string MakeGuess(int playerGuess)
        {
            string feedback;
            var guessModel = new GuessAppModel(playerGuess, "Try Again");

            if (playerGuess > target_Number)
            {
                feedback = "Too High!";
            }
            else if (playerGuess < target_Number)
            {
                feedback = "Too Low!";
            }
            else
            {
                feedback = "Congratulations, You guessed it!";
            }

            guessModel.GuessFeedback = feedback;
            guess_Data.AddGuess(guessModel); // Store the guess data

            return feedback;
        }

        public List<GuessAppModel> GetGuessHistory()
        {
            return guess_Data.GetAllGuesses();
        }
    }
}
