using System;
using System.Collections;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
            game();
            Console.WriteLine("Game Over");
            //implement switch for again and quit
            Console.ReadKey();
        }   

        private static void game()
        {
            int lives = 5;
            string guessWho = randomWord();
            Console.Write("Word:  ");
            char[] charList = guessWho.ToCharArray();
            char[] guessList = new char[guessWho.Length];
            ArrayList wrongList = new ArrayList();
            for (int i = 0; i < guessList.Length; i++) {
                guessList[i] = '_';
                Console.Write($"{guessList[i]} ");
            }
            Console.Write("\n\nMisses:  ");
            Console.Write("\nGuess:  ");
            while (gameEnd() != true & lives != 0)
            {
                char myGuess = Convert.ToChar(Console.ReadLine());
                if (Array.IndexOf(charList, myGuess)>=0)
                {
                    //atrast veidu, ka nomainit derigo burtu indeksus uz derigajiem burtiem
                    //atrast veidu, ka atrast visus indeksus, kas ir derigi varda
                }
                else {
                    wrongList.Insert(wrongList.Count, myGuess);
                    lives--;
                }
                Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
                Console.Write("Word:  ");
                for (int i = 0; i < guessList.Length; i++) {
                    Console.Write($"{guessList[i]} ");
                }
                Console.Write("\n\nMisses:  ");
                foreach (var item in wrongList) {
                    Console.Write(item.ToString());
                }
                if (lives != 0) 
                    Console.Write("\nGuess:  ");
                else 
                    Console.WriteLine("\n\nYour lives ran out, you lose!");
            }
        }
        private static string randomWord()
        {
            string[] myWords;
            myWords = new string[10] { "disgrace", "shocking", "blizzard", "brainstorm", "warning", "project", "stadium", "uniform", "breakfast", "mountain" };
            var rand = new Random();
            int i = rand.Next(0,10);
            return myWords[i];
        }

        private static bool gameEnd()
        {
            // if your lives run out OR
            // if you guess the word
            // return true
            return false;
        }
    }
}