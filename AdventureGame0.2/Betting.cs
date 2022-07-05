using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Betting
    {
        List<string> names = new List<string>();
        public string userInput, userChoice;
        public int userBet;
        Random rnd = new Random();
        public bool PlayerWin;

        public Betting()
        {
            //I use a seperate method and a conditional statement to check and see if the list has already been populated. If it has, then i keep the list, otherwise i populate it
            if(names.Count == 0)
            {
                CreateList();
            }

            Console.Clear();
            //Lets the player know how much they have in their pack
            Console.WriteLine("You check your backpack...");
            if (Backpack.InBackpack("money"))
            {
                Console.WriteLine("You have {0} gold to bet", Backpack.money);
                Console.WriteLine("Would you like to bet? (yes or no): ");
                userInput = Console.ReadLine().ToLower();
                //If they choose to bet, i use a while loop to stop them from inputting any amount more than what they have, and continue asking them for a bet amount
                if (userInput == "yes")
                {
                    Console.WriteLine("How much would you like to bet?: ");
                    userBet = Int32.Parse(Console.ReadLine());
                    while (userBet > Backpack.money)
                    {
                        Console.WriteLine("Well, would you look at that, you only have {0} gold in your pocket.\nAnd while it would be fun to have an adventure teaching you the danger of lying to a\nGnome booky, and all the pain that can come from it, let's stick to my original script and type a number of gold you want to bet.\nYou know, this time a number of gold you ACTUALLY have.", Backpack.money);
                        userBet = Int32.Parse(Console.ReadLine());
                    }
                    //Once i'm given a actual amount to bet, i initiate the fight
                    Fight(userBet);
                }
                else
                {
                    Choice3.WalkAway = true;
                }
                //If they don't bet, it ends the program without doing the fight. I put the bool walkaway to true so as to skip the while loop
                
            }
            else
            {
                //If they don't have money left, i set walkaway to true to break the loop
                Console.WriteLine("Unfortunatly, looks like you're dirt poor. The Gnome see's your empty pocket and laughs a snide laugh, turning his attention else where.");
                Choice3.WalkAway = true;
            }
        }

        public void CreateList()
        {
            names.Add("Steve");
            names.Add("Jeffery");
            names.Add("Justin");
            names.Add("Travis");
            names.Add("Bob");


        }

        public void Fight(int betAmount)
        {
            //Pig stats
            int pigStr, pigDex;

            //create wrestler stats and remove the name from the list, so they don't keep coming up.
            Wrestler wrestler1 = new Wrestler(names[rnd.Next(names.Count)], rnd.Next(10, 21), rnd.Next(10, 21), false);
            names.Remove(wrestler1.Name);

            //create pig stats
            pigDex = rnd.Next(10, 21);
            pigStr = rnd.Next(10, 21);

            //give player clues on who to bet
            if(wrestler1.Str > pigStr)
            {
                Console.WriteLine("{0} looks of strong stock.", wrestler1.Name);
            }
            else
            {
                Console.WriteLine("{0} looks a bit weaker.", wrestler1.Name);
            }

            if(wrestler1.Dex > pigDex)
            {
                Console.WriteLine("{0} looks quick on his feet.", wrestler1.Name);
            }
            else
            {
                Console.WriteLine("{0} looks a bit slow.", wrestler1.Name);
            }

            Console.WriteLine("Which do you bet on?\nA) The Wrestler\nB) The Pig");
            userChoice = Console.ReadLine().ToLower();

            //begin the fight
            if (wrestler1.Str > pigStr || wrestler1.Dex > pigDex)
            {
                wrestler1.Winner = true;
                Console.WriteLine("The fight is a long one, but eventually {0} pins the squealing pig on the ground and the crowd goes wild.", wrestler1.Name);
                Console.WriteLine("{0} has won!", wrestler1.Name);
            }
            else
            {
                wrestler1.Winner = false;
                Console.WriteLine("The fight is a long one, but eventually {0} moves to pin the pig.\nIn a twist of fate though, the pig escapes {0} grasp and {0} falls into the mud, breathing heavily, and not getting up.", wrestler1.Name);
                Console.WriteLine("The Pig Won!");
            }

            //Check to see if they won the bet
            if(userChoice == "a" && wrestler1.Winner)
            {
                Console.WriteLine("You won the bet!");
                userBet = betAmount * 2;
                Console.WriteLine("You won {0}!", userBet);
                PlayerWin = true;
            }else if(userChoice == "b" && !wrestler1.Winner)
            {
                Console.WriteLine("You won the bet!");
                userBet = betAmount * 2;
                Console.WriteLine("You won {0}!", userBet);

                PlayerWin = true;
            }
            else
            {
                Console.WriteLine("Looks like you lost the bet.");
                userBet = betAmount;
                Backpack.money = Backpack.money - userBet;
                PlayerWin = false;
            }
        }


    }
}
