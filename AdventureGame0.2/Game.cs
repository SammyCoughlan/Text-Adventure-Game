using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Game
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        static public string PlayerChoice;
        
        public Game()
        {
            
            music.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Fantasy Game Loop.wav";
            string title = @"
 _____      _  __  __ _       _      ______ _        ______            
|  __ \    (_)/ _|/ _(_)     ( )     | ___ (_)       |  _  \           
| |  \/_ __ _| |_| |_ _ _ __ |/ ___  | |_/ /_  __ _  | | | |__ _ _   _ 
| | __| '__| |  _|  _| | '_ \  / __| | ___ \ |/ _` | | | | / _` | | | |
| |_\ \ |  | | | | | | | | | | \__ \ | |_/ / | (_| | | |/ / (_| | |_| |
 \____/_|  |_|_| |_| |_|_| |_| |___/ \____/|_|\__, | |___/ \__,_|\__, |
                                               __/ |              __/ |
                                              |___/              |___/ 
";
            Console.Clear();
            music.PlayLooping();
            Console.WriteLine(title);
            Console.WriteLine("Press enter and prepare!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Welcome to the fantastical world of FaeRun");
            Console.WriteLine("You, Griffin, will participate in the Great festival! I hope nothing goes wrong...");
            Player player = new Player();
            Choice1 choice1 = new Choice1();
            Choice2 choice2 = new Choice2();
            Choice3 choice3 = new Choice3();
            Night night = new Night();
            Ending end = new Ending();

        }





        public static void Dialog(string message, string color)
        {



            if (color == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }else if (color == "cyan")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }else if (color == "orange")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }else if(color == "darkmagenta")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }else if(color == "darkred")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write(message);
            Console.ResetColor();

        }

        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.WriteLine("\n\nUnfortunatley you were unable to have a day as great as the one i promised. \nThe day is still there, however, and if you would like to try again, type yes below. \nOr if you'd rather be a quitter, type no.");
            PlayerChoice = Console.ReadLine().ToLower();
            if(PlayerChoice == "yes")
            {
                Game game2 = new Game();
            }
            else
            {
                Environment.Exit(0);
            }
        }

    }



}
