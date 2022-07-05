using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Choice2
    {
        string PlayerInput;
        string PlayerChoice;
        string FakeName;

        public Choice2()
        {
            Console.Clear();

            Console.WriteLine("You continue down the road.\nAs the sun begins to rise, and the time comes to noon, you are able to notice the great town\nof Neverwinter in the distance.\nIn hopes of adventure, and a hot meal, you continue forward.\nAs you approach the gate, you notice a distinct \nlack of vendors. A guard stands in your path, and he doesn't seem too happy to see you.");
            Game.Dialog("Halt! On kings order i am not to let anyone in. \nThe town is full, and you are late. Leave now, or else you risk arrest \nor worse.\n", "red");
            Console.WriteLine("What do you do?\nA)Walk Away like a coward and hope you can enter once someone exits.\nB)Talk with the guard, it worked well enough with the tree.\nC)Attack the guard.");
            PlayerInput = Console.ReadLine();
            PlayerInput = PlayerInput.ToUpper();
            if (PlayerInput == "A")
            {
                Console.Clear();
                Console.WriteLine("really.");
                Console.ReadKey();
                Console.WriteLine("Fine. You wait. \nLike all heros of legend, you sit on your behind and listen to the mayhem and fun coming from inside the walls. \nEventually someone exits the from the gate, and the guard motions you in.");
                Console.ReadKey();

            }
            else if (PlayerInput == "B")
            {
                Console.WriteLine("You begin to talk to the guard, who's face shows his disdain for his job.\nHe explains that he lost a bet and had to take this shift of guard duty.\nHe expresses his anger of having to miss the affair. \nHis stomach Growls loudly in agreement.\n");
                Console.WriteLine("What do you do?\nA) Promise to grab him something from the fair if he  lets you in.");

                if (Backpack.InBackpack("apple"))
                {
                    Console.WriteLine("\nB) Offer him that dank succulent fruit you got earlier");
                }

                Console.WriteLine("\nC) Do nothing, cause apparently you dont care about this game much.");

                PlayerChoice = Console.ReadLine().ToUpper();
                Console.Clear();
                if(PlayerChoice == "A")
                {
                    Console.WriteLine("The guard eyes you suspiciously, wondering if your telling the truth.\nafter a moment has passed he sighs and speaks:");
                    Game.Dialog("\nAw, what the hell. Get me a HotDog and some ale and we'll be square. \nBut if you arent here by nightfall, then i'm calling the guard on you. \nGive me your name just in case.\n", "red");
                    Console.WriteLine("do you\nA) Give him your real name, fairs fair.\nB) Tell him a fake name");
                    PlayerInput = Console.ReadLine().ToUpper();
                    Console.Clear();
                    if(PlayerInput == "A")
                    {
                        Game.Dialog(Player.Playername, Player.Color);
                        Console.WriteLine("\nYou say. In your mind you hope that won't come back to get you.");
                    }else if (PlayerInput == "B")
                    {
                        if(Player.PlayerInitial != Player.Playername)
                        {
                            Game.Dialog(Player.PlayerInitial, "cyan");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Told you it would be better if you were Griffin.");
                            Console.ReadKey();
                            Console.Clear();
                        }else
                        {
                            Console.WriteLine("\nWhat would you like your fake name to be?");
                            FakeName = Console.ReadLine();
                            Game.Dialog(FakeName, Player.Color);
                            Console.WriteLine("\nThe guard takes your word for it and ushers you into the fair. \nYou feel your excitment rise as the doors before you open, revealing the glorious fair.");
                        }
                    }
                    Backpack.Treasure = true;

                }else if(PlayerChoice == "B")
                {
                    Console.WriteLine("You fish around your backpack looking for that fruit you got. \nThe guard looks suspicious but doens't say anything.\nFinally you locate the fruit and pull it out triumphantly!\nThe guards eyes go wide and a smile breaks his otherwise angry face.");
                    Game.Dialog("Well, Would you look at that! that's from that ent on the road right?\nThe same one that killed Barry and maimed Susan right?", "red");
                    Console.WriteLine("\nYour suddenly very grateful you didnt try to steal from that tree.");
                    Console.WriteLine("\nYou throw the fruit to the guard and watch as his eyes light up. He takes a gigantic juicy bite out of it, \nand waves you in, cheeks full of dank succulence.");
                    Console.WriteLine("\nYou feel your excitement rise as the door before you open, revealing the glorious fair.");
                    Console.ReadKey();
                }else if(PlayerChoice == "C")
                {
                    Console.Clear();
                    Console.WriteLine("really.");
                    Console.ReadKey();
                    Console.WriteLine("Fine. You wait. \nLike all heros of legend, you sit on your behind and listen to the mayhem and fun coming from inside the walls. \nEventually someone exits the from the gate, and the guard motions you in.");
                    Console.ReadKey();
                }


            }else if (PlayerInput == "C")
            {
                Console.Clear();
                Console.WriteLine("*Sigh*\n\nYou never learn");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You pull your sword out and attack the guard.\nDespite his lazy appearance, he jumps into action, pulling his own sword. \nYour swords clash against each other.\nEventually, however, he strikes you in your ribs and you go down.\nYou take 5 damage");
                Console.ReadKey();
                Player.TakeDamage(5);
                Console.WriteLine("You crawl away before more damage can be dealt.");
                Game.GameOver();
            }


        }


    }
}
