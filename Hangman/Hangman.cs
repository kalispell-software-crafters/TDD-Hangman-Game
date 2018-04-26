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

            if (NumberOfGuesses == 0 || FoundWord())
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
    }
}
