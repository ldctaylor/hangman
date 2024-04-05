namespace Hangman
{
    internal class Program
    {
        static void Main()
        {
            IntroductionText.PrintIntro();
            GameHost.StartGame();
            Word word = GameHost.AskForWord();
            GameHost.AskForLetter(word);


        }
    }
}
