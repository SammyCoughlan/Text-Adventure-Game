using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Player
    {

        string Playerinput;
        static public string PlayerChoice;
        static public string PlayerInitial;
        static public string Color;
        static public string Playername = "Griffin";
        static public int RemainingHealth = 10;
        static public int StartingHealth = 10;
        

        public Player()
        {


            Console.WriteLine("First you will need a name. Go ahead and insert any name of your choosing!");
            Playerinput = Console.ReadLine();
            PlayerInitial = Playerinput;
            if (Playerinput != Playername)
            {
                Console.WriteLine("Are you sure it's not " + Playername + "? \n Cause thats, like, the whole title and evreything. I mean, i guess Griffin Cool Dude could be having a great day \n at the same time as " + Playerinput + " but it would make more sense if You were Griffin. \n Lets try this again. \n Please type your name");
                Playerinput = Console.ReadLine();

                if (Playerinput != Playername)
                {
                    Console.WriteLine("Okay, fine. Making my job hard. Lets begin.");
                    Playername = Playerinput;
                    Console.WriteLine("Press enter to start, "+ Playername);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Thought so. Okay Griffin Cool dude! Press enter and Lets start this party!");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Now you can choose your color of your dialog! The following options are:\nBlue\nRed\nGreen\nYellow\nOr Orange");
            Color = Console.ReadLine().ToLower();
            while(Color != "blue"&&Color != "red"&& Color != "green"&& Color != "yellow" && Color != "orange"){
                Console.WriteLine("Entry not valid. Please enter one of the following: Blue, Red, Green, Yellow, Or Orange.");
                Color = Console.ReadLine().ToLower();

            }
            Console.WriteLine("Gotcha! From now on, you're dialog will be presented in {0}", Color);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        public static void TakeDamage(int damage)
        {
            RemainingHealth = RemainingHealth - damage;
            if(RemainingHealth == 0)
            {
                Console.Clear();
                Console.WriteLine("Unfortunatley you have perished!\nDo you wish to play again(yes or no)?: ");
                PlayerChoice = Console.ReadLine();
                PlayerChoice = PlayerChoice.ToLower();
                if(PlayerChoice == "yes")
                {
                    Game game2 = new Game();
                }else
                {
                    Environment.Exit(0);
                }

            }
            else
            {
                Console.WriteLine("You have "+ RemainingHealth + " health left");
            }
        }

        public static int CheckHealth()
        {
            return RemainingHealth;
        }


    }
}
