using System;

namespace NumberGuessingGameWeb.Services
{
    public class GameService
    {
        private int _randomNumber;
        private int _numberOfTries;

        public GameService()
        {
            _randomNumber = new Random().Next(1, 101); // Random number between 1 and 100
            _numberOfTries = 0;
        }

        public string Guess(int userGuess)
        {
            _numberOfTries++;
            if (userGuess < _randomNumber)
            {
                return "Too low! Try again.";
            }
            else if (userGuess > _randomNumber)
            {
                return "Too high! Try again.";
            }
            else
            {
                return $"Congratulations! You've guessed the number in {_numberOfTries} tries.";
            }
        }

        public void ResetGame()
        {
            _randomNumber = new Random().Next(1, 101);
            _numberOfTries = 0;
        }
    }
}
