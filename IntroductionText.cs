using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal static class IntroductionText
    {
        static string title = ($"*****************************\n********** HANGMAN **********\n*****************************");
        static string instruction = "You need to enter a word for someone else to guess: ";

        internal static void PrintIntro()
        {
            Console.WriteLine(title);
            Console.WriteLine(instruction);
        }
    }
}
