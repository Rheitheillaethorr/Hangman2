using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new HangmanGame();

            game.Start();
        }
    }
}
