using System.Collections.Generic;
using System
namespace Hangman2.Model
{
    public class Game
    {
        public string WordToGuess { get; set; }
        public int Score { get; set; }
        public List<string> UsedCharacters { get; set; }

        public Game(string wordToGuess)
        {
            WordToGuess = wordToGuess;
            Score = 0;
            UsedCharacters = new List<string>();
        }

        public void AddPoint()
        {
            var pointValueForGuessing = 5;
            Score=+pointValueForGuessing;
        }

        public void SubtractPoint()
        {
            Score--;
        }

        public void MarkCharacterAsUsed(string character)
        {
            UsedCharacters.Add(character);
        }

        public bool AllCharacterAreGuessed()
        {
            //3. Check if all character are already guessed
            //...
            return false;
        }

        public bool IfAlreadyUsed(string character)
        {
            if (UsedCharacters.Contains(character))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
