using System;

namespace GuessingApplication.Models
{
    public class GuessAppModel
    {
        public int PlayerGuess { get; set; }
        public string GuessFeedback { get; set; }
        public DateTime GuessTime { get; set; }

        public GuessAppModel(int playerGuess, string guessFeedback)
        {
            PlayerGuess = playerGuess;
            GuessFeedback = guessFeedback;
            GuessTime = DateTime.Now;
        }
    }
}
