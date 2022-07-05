using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Ending
    {
        public Ending()
        {
            Console.Clear();
            if(Night.ending == "jail")
            {
                if(Choice3.fortune == "Death")
                {
                    Console.WriteLine("As you sit in jail, you offhandedly say something you thought was funny,\nBut unfortunatly the orc does not.");
                    Console.WriteLine("The guards find you dead body in the morning.");
                    Console.WriteLine("Looks like your day was not so great. But that's okay, you can try again for another ending if you'd like!");
                }
                else
                {
                    Console.WriteLine("You don't really sleep much in the cell./nYou reflect upon your day, finding it not so grand all in all.");
                    Console.WriteLine("Looks like your day was not so great. But that's okay, you can try again for another ending if you'd like!");
                }
            }else if (Night.ending == "inn")
            {
                if(Choice3.fortune == "Death")
                {
                    Console.WriteLine("You settle in comfortably for the night.\nHowever, as you sleep someone creeps into your room.\nYou rise just in time for you ultimate end.");
                    Console.WriteLine("The innkeep finds your body in the morning.");
                    Console.WriteLine("Looks like your day was not so great. But that's okay, you can try again for another ending if you'd like!");
                }
                else
                {
                    Console.WriteLine("As you settle into the comfortable bed you look over your whole day.\nAll in all, it was a pretty great day!");
                    Console.WriteLine("Congrats! You narrowly avoided having a bad day, and ended up having the best day!");
                }
            }else if (Night.ending == "camp")
            {
                if(Choice3.fortune == "Death")
                {
                    Console.WriteLine("You begin to fall asleep, the stars above you, when along comes a hungry wolf.\nDespite your best tries, it gets the better of you.\nThe guards find your body in the morning.");
                    Console.WriteLine("Looks like your day was not so great. But that's okay, you can try again for another ending if you'd like!");
                }
                else
                {
                    Console.WriteLine("As you settle into your sleeping bag, watching the stars above you, you look back on your day.\nAll in all it was a pretty decent day.");
                    Console.WriteLine("Congrats! You may have not had the best day, but you had a rather decent one.\nIf you'd like, you can try again to have an even better day!");
                }
            }

        }




    }
}
