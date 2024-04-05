using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Word
    {
        string _word;
        int _length;
        char[] _guessedLetters;
        List<char> _incorrectLetters;
        internal int _numberOfTries;

        internal Word(string word)
        {
            _word = word.ToUpper();
            _length = word.Length;
            _guessedLetters = new char[_length];
            _incorrectLetters = new List<char>();
            _numberOfTries = 0;

            for (int i = 0; i < _length; i++)
            {
                _guessedLetters[i] = '_';
            }
        }

        internal void GuessedLetters()
        {
            foreach (char letter in _guessedLetters)
            {
                Console.Write($"{letter}  ");
            }
            if (_incorrectLetters.Count > 0)
            {
                Console.Write($"\nIncorrect Guesses:   ");
                foreach (char letter in _incorrectLetters)
                {
                    Console.Write($"{letter}  ");
                }

            }
            if (_numberOfTries > 0)
            {
                Console.WriteLine($"\nNumber of tries: {_numberOfTries}\n");
            }
        }

        internal bool CheckIfWon()
      {
            if (!_guessedLetters.Contains('_'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void CheckLetter(char letter)
        {
            if (_guessedLetters.Contains(char.ToUpper(letter)) || (_incorrectLetters.Contains(char.ToUpper(letter))))
            {
                Console.WriteLine("You already guessed that letter!\n");
                }
            else if (_word.Contains(char.ToUpper(letter)))
            {
                Console.WriteLine($"Yes! {letter} is in the word!\n");

                for (int i = 0; i < _length; i++)
                {

                    if (_word[i] == char.ToUpper(letter))
                    {
                        _guessedLetters[i] = char.ToUpper(letter);
                    }
                }
            }
            else
            {
                _incorrectLetters.Add(char.ToUpper(letter));
                Console.WriteLine($"NOPE! {letter} is not in the word!\n");
                Console.Beep(500, 200);
                Console.Beep(200, 1000);
            }

            if (CheckIfWon())
            {
                Console.WriteLine($"You guessed the word in {_numberOfTries} tries! Nice one!");
                return;
            }
        }
    }
}
