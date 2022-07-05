using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Choice1
    {

        public Choice1()
        {
            string playerChoice;

            Console.Clear();
            Console.WriteLine("You come across a strange tree with an old gnarled face. It has beautiful ripe fruit on it's branches \nand it has not seen you.");
            Console.WriteLine("Do you,\nA) Leave it alone and keep walking.\nB) Steal the fruits from it's branches before it notices you\nC) Introduce yourself and ask the tree for a fruit");
            playerChoice = Console.ReadLine().ToUpper();
            if (playerChoice == "A")
            {
                Console.WriteLine("You have choosen to walk past this perfect opportunity for character development and continue down the road.\nWow, i hope your not this boring at the actual festival.");
                Console.ReadKey();

            }
            else if (playerChoice == "B")
            {
                Console.WriteLine("You lower yourself to the ground in an attempt to hide from it's sights and creep forward.\nYou nimbly climb silently up the tree beside him and grasp for a fruit\nUnfortunatley you are not as nimble as you thought,\nThe tree turns just as your hand clasps the apple.\nYou are plucked from your perch and thrown against another tree.\nYou decide to run before the tree gets any angrier.\nYou take 5 damage");
                Player.TakeDamage(5);
                Console.ReadKey();

            }
            else if (playerChoice == "C")
            {

                

                Console.WriteLine("You decide to speak up, despite the large imposing branches that the tree has \n(you never expected to think that today)\n");
                Game.Dialog("Excuse me, ", Player.Color);
                Console.WriteLine("\nYou say. The tree turns its gaze to you. \nFor a moment you worry that you've upset it, but then it parts its craacked, bark encrusted lips and says: ");
                Game.Dialog("Oh dope! Hell Yeah homie. \nUsually people just yank them off without asking so i have to bludgeon them to death with my big terrifying tree arms. \nI really appreciate you taking my feeling into consideration.\nHere, have my dankest most succulent fruit!", "green");
                Console.WriteLine("\nYou Got 1 Dank, Succulent Fruit!");
                Backpack.HasApple = true;
                Console.WriteLine("\nYou thank the Tree, and head back towards the road and the town");
                Console.ReadKey();
            }
        }


    }
}
