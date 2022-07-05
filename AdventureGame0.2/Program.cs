using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Program
    {

        /* Programming by Samantha Coughlan
         * ASCII art from patorjk.com
         * Credit to reddit user Miss_Behaves for the funny tree lines in Choice 1
         * Credit to Lord of The Rings for three of the four riddles.
         * Credit to Sophocles for the sphinx's riddle contained within Oedipus
         * Credit to dl-sounds.com for the music loop
         * Credit to help with debugging issues to Stack Overflow and docs.Microsoft.com
         */

        public static string choice;
        public static bool end = false;
        static void Main(string[] args)
        {

            Game game1 = new Game();
            while (!end)
            {
                Console.WriteLine("Would you like to reset and try again? (Y/N): ");
                choice = Console.ReadLine().ToLower();
                if (choice == "y")
                {
                    Game game2 = new Game();
                }
                else
                {
                    Environment.Exit(0);
                    end = true;
                }
            }

        }
    }
}
