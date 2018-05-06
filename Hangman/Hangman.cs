using System;
using System.Collections.Generic;

namespace HangmanGame
{
    public class Hangman
    {
        public Hangman()
        {
        }

        public bool GuessLetter(char letter)
        {
            bool foundLetter = false;

            if (SecretWord.Contains(letter.ToString().ToUpper()))
            {
                foundLetter = true;
            }

            Guesses.Add(Char.ToUpper(letter));

            return foundLetter;
        }

        public bool EnterWord(string secretWord)
        {
            if (!string.IsNullOrWhiteSpace(secretWord))
            {
                this.SecretWord = secretWord.ToUpper();
                return true;
            }

            return false;
        }

        private List<char> Guesses
        {
            get;
            set;
        } = new List<char>();

        private string SecretWord
        {
            get;
            set;
        } = String.Empty;

        private int NumberOfGuesses
        {
            get;
            set;
        }

        public bool GameOver()
        {
            bool isOver = false;

            if (NumberOfRemainingGuesses() <= 0 || FoundWord())
            {
                isOver = true;
            }

            return isOver;
        }

        public void SetDifficulty(Enums.Difficulty difficulty)
        {
            NumberOfGuesses = (int)difficulty;
        }

        public int NumberOfRemainingGuesses()
        {
            return NumberOfGuesses - Guesses.Count;
        }

        public bool FoundWord()
        {
            bool hasFoundWord = false;

            foreach (char c in SecretWord)
            {
                if (Guesses.Contains(c))
                {
                    hasFoundWord = true;
                }
                else
                {
                    hasFoundWord = false;
                    break;
                }
            }

            return hasFoundWord;
        }

        public bool Loop()
        {
            //Setup Game
            //Play Game
            return false;
        }

        public bool PlayGame()
        {
            // TODO Outputs to concole current guesses, found letters, and remaing free guesses
            // Guess letters (win/lose)
            // Validation checks?

            return false;   
        }

        public bool SetupGame(string word, Enums.Difficulty difficulty)
        {
            //enter word
            //enter difficulty
            //check values

            return false;
        }
    }
}
