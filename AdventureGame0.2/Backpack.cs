using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Backpack
    {
        public static bool HasApple;
        public static bool Treasure = false;
        public static int money = 5;

        public Backpack()
        {

        }


        public static bool InBackpack(string item)
        {
            string Item = item.ToLower();
            if(Item == "apple")
            {
                if (HasApple)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else if (Item == "treasure")
            {
                if (Treasure)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else if (Item == "money")
            {
                if (money > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else
            {
                Console.WriteLine("ERROR: InBackpack() has failed");
                return false;
            }



        }



    }
}
