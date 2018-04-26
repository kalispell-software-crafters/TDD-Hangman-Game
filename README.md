# Hangman with TDD

Our Meetup group's session on April 25th 2018 practiced Test Driven Development (using the three laws of TDD) by programming the word game Hangman. We've uploaded the code for review and completion. We weren't able to complete the whole thing but we left off with completely green tests! Below are some of the notes we made for how the game will play.

## Quick Notes

Hangman - Two Players

1 Player 1 enters a secret word and sets the difficulty (# of wrong guesses)  
2 Player 2 guesses a letter  
3 Then we check if the letter is within the word  
4 We will either show the correct letter placement OR mark a wrong guess  
5 We'll refresh the display (should we show past wrong guesses?)  
6 Repeat this process (steps 2 - 5) until the game is over  
	i.e. we either guessed the word OR failed to guess the word within the limit  

Future plans: Validate that the secret word is in fact a real word

Things to consider:  
Secret word  
Guess list  
"Formed" word (what player 2 has correctly guessed during play)  
Remaining guesses (i.e. 9)  

## Resources

Three Laws of TDD: http://programmer.97things.oreilly.com/wiki/index.php/The_Three_Laws_of_Test-Driven_Development
