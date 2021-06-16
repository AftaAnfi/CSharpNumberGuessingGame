using System;

namespace CSharpGuessingNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputPhase = true;
            Console.Title = "Number Guessing Game";
            Console.WriteLine("Press Enter to play!");
            Console.ReadLine();
            Random r = new Random(DateTime.Now.Millisecond);
            int inputInt = 0;

            while (inputPhase)
            {
                int randInt = r.Next(1, 11);
                Console.WriteLine("Pick a number between 1 and 10 or Q to quit");
                string inputString = Console.ReadLine();

                if (inputString == "Q" || inputString == "q")
                {
                    Environment.Exit(0);
                }

                try
                {
                    inputInt = Convert.ToInt32(inputString);

                    if (inputInt == randInt)
                    {
                        Console.WriteLine("You guessed it right!");
                    }
                    else
                    {
                        //Console.WriteLine("You sucks haha");
                        Console.WriteLine("You didn't guess it right. Better luck next time!");
                    }

                    EnterDialog();
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("That wasn't a number...Try again...");
                    EnterDialog();
                    Console.Clear();
                }

            }

            void EnterDialog()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
