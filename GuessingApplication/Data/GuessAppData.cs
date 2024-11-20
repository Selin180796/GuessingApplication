using GuessingApplication.Models;  

namespace GuessingApplication.Data
{
    public class GuessAppData
    {
        public List<GuessAppModel> GuessHistory { get; set; }

        public GuessAppData()
        {
            GuessHistory = new List<GuessAppModel>();
        }

        public void AddGuess(GuessAppModel guess)
        {
            GuessHistory.Add(guess);
        }

        public List<GuessAppModel> GetAllGuesses()
        {
            return GuessHistory;
        }
    }
}
