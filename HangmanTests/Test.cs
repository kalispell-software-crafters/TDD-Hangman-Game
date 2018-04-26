using NUnit.Framework;
using System;
using HangmanGame;

namespace HangmanTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void Hangman_GuessLetter_Positive()
        {
            Hangman game = new Hangman();
            game.EnterWord("All");
            bool isFound = game.GuessLetter('a');

            Assert.AreEqual(true, isFound, "The guess was wrong.");
        }

        [Test()]
        public void Hangman_GuessLetter_Negative()
        {
            Hangman game = new Hangman();
            game.EnterWord("All");
            bool isFound = game.GuessLetter('z');

            Assert.AreEqual(false, isFound, "The guess was wrong.");
        }

        [Test()]
        public void Hangman_EnterWord()
        {
            Hangman game = new Hangman();

            bool isSuccessful = game.EnterWord("Alligator");

            Assert.AreEqual(true, isSuccessful, "The EnterWord method failed");
        }

        [Test()]
        public void Hangman_EnterWord_Blank()
        {
            Hangman game = new Hangman();

            bool isSuccessful = game.EnterWord("");

            Assert.AreEqual(false, isSuccessful, "The EnterWord method should have failed");
        }

        [Test()]
        public void Hangman_GameOver_True()
        {
            Hangman game = new Hangman();

            bool isOver = game.GameOver();

            Assert.AreEqual(true, isOver, "The GameOver method is failing.");
        }

        // TODO Clean up names and add more tests

        [Test()]
        public void Hangman_GameOver_FoundWord_True()
        {
            Hangman game = new Hangman();
            game.SetDifficulty(Enums.Difficulty.Medium);
            game.EnterWord("All");

            game.GuessLetter('a');
            game.GuessLetter('L');

            bool isOver = game.GameOver();

            Assert.AreEqual(true, isOver, "The GameOver method is failing.");
        }

        [Test()]
        public void Hangman_GameOver_Medium_False()
        {
            Hangman game = new Hangman();
            game.SetDifficulty(Enums.Difficulty.Medium);

            bool isOver = game.GameOver();

            Assert.AreEqual(false, isOver, "The GameOver method is failing.");
        }

        [Test()]
        public void Hangman_NumberOfRemainingGuesses_Easy()
        {
            Hangman game = new Hangman();
            game.SetDifficulty(Enums.Difficulty.Easy);

            int remainingGuesses = game.NumberOfRemainingGuesses();

            Assert.AreEqual((int)Enums.Difficulty.Easy, remainingGuesses, "The NumberOfRemainingGuess method is failing.");
        }

        [Test()]
        public void Hangman_NumberOfRemainingGuesses_Medium()
        {
            Hangman game = new Hangman();
            game.SetDifficulty(Enums.Difficulty.Medium);

            int remainingGuesses = game.NumberOfRemainingGuesses();

            Assert.AreEqual((int)Enums.Difficulty.Medium, remainingGuesses, "The NumberOfRemainingGuess method is failing.");
        }

        [Test()]
        public void Hangman_NumberOfRemainingGuesses_Hard()
        {
            Hangman game = new Hangman();
            game.SetDifficulty(Enums.Difficulty.Hard);

            int remainingGuesses = game.NumberOfRemainingGuesses();

            Assert.AreEqual((int)Enums.Difficulty.Hard, remainingGuesses, "The NumberOfRemainingGuess method is failing.");
        }

        [Test()]
        public void Hangman_FoundWord_Empty()
        {
            Hangman game = new Hangman();

            bool hasFoundWord = game.FoundWord();

            Assert.AreEqual(false, hasFoundWord, "The FoundWord method failed.");
        }

        [Test()]
        public void Hangman_FoundWord()
        {
            Hangman game = new Hangman();

            game.EnterWord("Secret");
            game.GuessLetter('S');
            game.GuessLetter('r');
            game.GuessLetter('c');
            game.GuessLetter('t');
            game.GuessLetter('e');
            bool hasFoundWord = game.FoundWord();

            Assert.AreEqual(true, hasFoundWord, "The FoundWord method failed.");
        }
    }
}
