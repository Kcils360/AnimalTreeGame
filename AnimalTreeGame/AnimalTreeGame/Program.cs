using System;
using System.Linq;


namespace AnimalTreeGame
{
    class Program
    {
        static Tree tree;
        static void Main(string[] args)
        {
            StartNewGame();
            Console.WriteLine("\nStarting the Game");
            tree.Query(); //play one game
            while (PlayAgain())
            {
                Console.WriteLine();
                tree.Query(); //play one game
            }


        }

        static void StartNewGame()
        {
            Console.WriteLine("No previous knowledge found!");
            Console.WriteLine("Initializing a new game.\n");
            Console.WriteLine("Enter a question about an object: ");
            string question = Console.ReadLine();
            Console.Write("Enter a guess if the response is Yes: ");
            string yesGuess = Console.ReadLine();
            Console.Write("Enter a guess if the response is No: ");
            string noGuess = Console.ReadLine();
            tree = new Tree(question, yesGuess, noGuess);
        }

        static bool PlayAgain()
        {
            Console.Write("\nPlay Another Game? ");
            char inputCharacter = Console.ReadLine().ElementAt(0);
            inputCharacter = Char.ToLower(inputCharacter);
            while (inputCharacter != 'y' && inputCharacter != 'n')
            {
                Console.WriteLine("Incorrect input please enter again: ");
                inputCharacter = Console.ReadLine().ElementAt(0);
                inputCharacter = Char.ToLower(inputCharacter);
            }
            if (inputCharacter == 'y')
                return true;
            else
                return false;
        }
    }
}
