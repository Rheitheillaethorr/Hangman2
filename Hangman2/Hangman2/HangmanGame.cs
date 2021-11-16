﻿using Hangman2.Model;
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
            string category = RandomizeTheCategory();
            //2. Get random password
            //...
            var randomWord = RandomizeThePhrase(category);

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
            Console.Clear();

            //5. Ready user input
            //If it was already used then write that information on console
            //...
            var userInput = "a";

            //6. Check if it is correct guess
            //... gameConfig.UsedCharacters
            gameConfig.MarkCharacterAsUsed(userInput);
            gameConfig.AddPoint();
        }

        static string RandomizeTheCategory()
        {
            Random rnd = new Random();
            int randomCategory = rnd.Next(0, 4);
            switch (randomCategory)
            {
                case 0:
                    Console.WriteLine("Computer choose fruits");
                    return "fruits.txt";
                case 1:
                    Console.WriteLine("Computer choose animals");
                    return "animals.txt";
                case 2:
                    Console.WriteLine("Computer choose sport");
                    return "sport.txt";
                case 3:
                    Console.WriteLine("Computer choose countries");
                    return "countries.txt";
                default:
                    return RandomizeTheCategory();
            }
        }

        static string RandomizeThePhrase(string TextFileName)
        {
            int lineCount = File.ReadAllLines(TextFileName).Length;
            Random rnd = new Random();
            int randomLine = rnd.Next(0, lineCount);
            string wordToGuess = File.ReadLines(TextFileName).Skip(randomLine - 1).Take(1).First();
            Console.WriteLine("Generated phrase is: " + wordToGuess);
            return wordToGuess;
        }

    }
}
