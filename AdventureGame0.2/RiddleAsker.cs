using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class RiddleAsker
    {
        public static int Bet;
        public static List<Riddles> rndriddles = new List<Riddles>() { new Riddles(1), new Riddles(2), new Riddles(3), new Riddles(4) };
        public RiddleAsker()
        {

        }

        public static void RiddleBegin(int B)
        {
            Random rnd = new Random();
            int random = rnd.Next(rndriddles.Count());
            rndriddles[random].AskRiddle();
            rndriddles.Remove(rndriddles[random]);
            if (Riddles.win)
            {
                Bet = 2 * B;
                Console.WriteLine("The old man begins to chuckle. He reaches into the bag to match the bet and hands you the money.");
                Game.Dialog("Well aren't you a smart cookie! here you go, now run on!\n", "orange");
                Backpack.money = Backpack.money + B;
            }
            else
            {
                Console.WriteLine("You watch as the old man cackles again and drops the gold into the bag at his feet.\n");
                Backpack.money = Backpack.money - B;
            }


        }


    }
}
