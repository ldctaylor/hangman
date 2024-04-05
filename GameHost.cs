using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hangman
{
    internal static class GameHost
    {
        internal static void StartGame()
        {
            Console.Write("Hi, I'm the Game Host! What's your name? ");
            string? name = Console.ReadLine();
            Player player = new Player(name);
            Console.WriteLine($"Nice to meet you, {player._name}! Let's play Hangman!");
            Console.WriteLine($"\n\n");
        }

        internal static Word AskForWord()
        {
            Console.WriteLine("You need to enter a word for someone else to guess: ");
            string word = Console.ReadLine();
            Word wordToGuess = new Word(word);
            Console.Clear();
            Console.WriteLine("Ok, it's showtime! Guess the word! \n");
            return wordToGuess;
        }

        internal static void AskForLetter(Word word)
        {
            while (true)
            {
                word.GuessedLetters();
                Console.Write("\nEnter a letter: ");
                string? input = Console.ReadLine();
                word._numberOfTries++;
                if (input.Length == 1)
                {
                    char letter = input[0];
                    if (char.IsLetter(letter))
                    {
                        letter = char.ToUpper(letter);
                        word.CheckLetter(letter);
                        if (word.CheckIfWon())
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{input} is not a letter. Please enter a letter.\n");
                        Console.WriteLine($"{word._numberOfTries} tries so far.\n");
                    }
                }
            }
            }
        }

    }

