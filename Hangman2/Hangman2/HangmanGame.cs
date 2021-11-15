using Hangman2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman2
{
    class HangmanGame
    {
        private Game gameConfig;

        public void Start() 
        {
            //1. read file with words to guess
            //...

            //2. Get random password
            //...
            var randomWord = "hangman";

            gameConfig = new Game(randomWord);

            while (!gameConfig.AllCharacterAreGuessed())
            {
                NextRound();
            }

            Console.WriteLine($"Game is over, your score is: {gameConfig.Score}");
        }

        private void NextRound()
        {
            //4. Clear console screen
            //... Write user current score / word with guessed characters like 'han_g_an' / used characters

            //5. Ready user input
            //If it was already used then write that information on console
            //...
            var userInput = "a";

            //6. Check if it is correct guess
            //... gameConfig.UsedCharacters
            gameConfig.MarkCharacterAsUsed(userInput);
            gameConfig.AddPoint();
        }
    }
}
