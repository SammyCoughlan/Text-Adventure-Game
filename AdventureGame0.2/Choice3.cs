using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Choice3
    {


        public string userChoice, userInput;
        public static string fortune;
        public static bool secondFortune;
        public int userBet;
        public static bool WalkAway = false;
        public static int Night = 0;
        ConsoleKeyInfo cki;
        Random rnd = new Random();

        public Choice3()
        {
            secondFortune = false;
            Console.Clear();
            Console.WriteLine("As you enter, the absolute mass of the kingdom at peek capacity finally settles into view.\nYou stare, mouth agape, at the festival, it's streamers speckiling the sky\nA number of races, ones you know and others you don't, melded in with the crowd.\nA sign stood at the entrance with three arrows lined with text from different languages.");
            //I use a night int that will be added to at the end of every choice, and when the time has approached "Night" or when three choices have ended, then the loop will break
            while (Night != 3)
            {
                //this will clear the screen if the loop has executed at least once
               if(Night > 0)
                {
                    Console.Clear();
                }
                Console.WriteLine("\nWhat exciting Festival Game will you choose?");
                Game.Dialog("\nA)Pig wrestling\nB)Riddle Solving\nC)Fortune Teller\n", "yellow");
                userChoice = Console.ReadLine().ToLower();

                if (userChoice == "a")
                {
                    //Player choose to pig wrestle. Begin the betting process
                    Console.WriteLine("You find your way to the pig wrestling pit, and find a heavley musceled man grappiling with a hog in the mud.\nPeople around your cheer and jeer.\nOnce the man pins the hog, the crowd goes wild.\nSome people swear about the money they lost, \nothers cheered and huddled around a small gnome, who gives out coins to them.\nThe Gnome catches you looking and begins to shout over the crowds din: ");
                    Game.Dialog("\nCome one, Come All! Bet on the winner of the next match! You! Come forth and try your luck!", "green");
                    Console.ReadKey(true);
                    Betting bet1 = new Betting();
                    //I initiate a loop to allow the player to bet as long as they have money.

                    while (!WalkAway)
                    {

                        //If they didn't win, then i allow them to use the remaining money they have to bet more. If they don't have more, they are forced to walk away
                        if (!bet1.PlayerWin)
                        {
                            Game.Dialog("Well, looks like you're luck has run out. Why don't you do the right thing and walk away now buddy.\n", "green");
                            if (Backpack.InBackpack("money"))
                            {
                                Console.WriteLine("Do you\nA) Walk Away\nB) Keep Betting");
                                userInput = Console.ReadLine().ToLower();
                                if (userInput == "a")
                                {
                                    //If they don't want to bet, i set WalkAway to true and skip the loop and betting
                                    WalkAway = true;
                                }
                                else if (userInput == "b")
                                {
                                    //if they choose to bet, they are brought to the betting program again to determine if they can and how much they do bet.
                                    Betting bet2 = new Betting();
                                }
                            }
                            else
                            {
                                Console.WriteLine("With a hopeful gleam you look into your bag to find it devoid of gold.\nThe Gnome sneers as you walk away, much poorer than when you came.");
                                WalkAway = true;
                            }
                        }
                        //If the player won, the gnome will offer to double or nothing his bet
                        if (bet1.PlayerWin)
                        {
                            Console.WriteLine("You walk over to collecgt your winnings, and the Gnome flashes a smile.");
                            Game.Dialog("Looks like Luck is on your side!\nI could give you your winnings now, or i can offer you something better.\nI can put your winnings toward the next fight, and if you win, you double the money!\nWhaddya say?", "green");
                            Console.WriteLine("\nYes or no?");
                            userChoice = Console.ReadLine().ToLower();
                            //If the player does want to keep betting, then run another fight with the bet amount being the winnings from before.
                            if (userChoice == "yes")
                            {
                                //If they choose the gnomes deal, they skip past the intital betting program, cause their bet has already been determined as what they won before.
                                Console.WriteLine("The Gnome smiles.");
                                Game.Dialog("\nI know a gambler when i see one! And you are on a roll my friend!", "green");
                                Console.WriteLine("\nThere's a few more minutes of people throwing bets in before the next fight starts.");
                                bet1.Fight(bet1.userBet);
                            }
                            else
                            {
                                //Otherwise i set the WalkAway to true and break the loop.
                                WalkAway = true;
                            }
                        }
                    }
                    //When the loop ends, the choice's continue
                    Console.WriteLine("You walk away, for better or for worse.");
                    Night++;

                }
                else if (userChoice == "b")
                {
                    //If the user chooses riddles, i set up the scene of the Riddlemaster
                    Console.Clear();
                    int bet;
                    //I ask if the user would like to engage
                    Console.WriteLine("You walk towards where the signs are pointing and find yourself at the entrance of the Wizard Hall\nA bearded old man sleeps on a chair in front of it\nA sign reads: Wake me for riddles\nDo you wake him? (yes or no)");
                    userInput = Console.ReadLine().ToLower();
                    if(userInput == "yes")
                    {
                        string choice;
                        Console.WriteLine("You kick the old mans shin lightly. The calm snores of the old man turns to coughs of surprise.\nAfter his fit he opens his withered eyes.\nThey scan you slowly, and intently.\nThe man smiles, and you can see he is missing most of his teeth.\nYou begin to dread waking him up.");
                        Game.Dialog("Well Hiya, Young girl!\n", "orange");
                        Console.WriteLine("While gender is a fluid notion, You do not consider yourself young, or female.");
                        Game.Dialog("Are you here for a riddle! Oh how exciting! Before we get to the fun part however, let me explain the rules!\nI will ask you how much money you'd like to wager.\nIf you guess succesfully, then I will give you back double the amount! \nif not however, the money is mine!\n", "orange");
                        Console.WriteLine("The old man cackles, and you now see that the large bag at his feet is filled with coin.");
                        if(Backpack.money == 0)
                        {
                            Game.Dialog("Now don't you worry, little girl, if your mom didn't give you any coin! for such a pretty princess, I'll throw in a single gold for ya, out of my own pocket!\n", "orange");
                        }
                        Console.WriteLine("Do you bet? (Y/N): ");
                        choice = Console.ReadLine().ToLower();
                        if(choice == "y"&&Backpack.InBackpack("money"))
                        {
                            //If they have money in their backpack, then i tell them how much and ask them how much they would like to bet.
                            Console.WriteLine("you have {0} gold in your backpack.", Backpack.money);
                            Console.WriteLine("How much would you like to bet: ");
                            bet = Convert.ToInt32(Console.ReadLine());
                            //If they input a number larger than the amount they have, i use a while loop to keep asking for input until the amount is equal to or lower than the amount.
                            while(bet > Backpack.money)
                            {
                                Console.WriteLine("How about we try this again. This time, i want you to enter an amount of coin you have in your bag.");
                                Console.WriteLine("How much are you betting?: ");
                                bet = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("You hand the man {0} gold, and he turns it over in his hands", bet);
                            Console.WriteLine("The man leans back in his chair and begins to ask you a riddle.");
                            //Begin the random riddle selection
                            RiddleAsker.RiddleBegin(bet);
                        }else if (choice == "y"&& !Backpack.InBackpack("money"))
                        {
                            //If they have no money, then i have the old man bet a coin for them.
                            Console.WriteLine("The old man reaches down to the bag below and takes out one gold.\nNot really out of 'His own poket' is it?");
                            bet = 1;
                            //Begin the random riddle selection
                            RiddleAsker.RiddleBegin(bet);

                        }
                        //If they say they dont want to engage the riddle asker, then i have the if statement terminate and have them walk away.
                    }
                    Console.WriteLine("You walk away. The sky gets darker above you.");
                    //I increase the night clock by one.
                    Night++;
                    Console.ReadKey();
                }
                else if (userChoice == "c"&&!secondFortune)
                {
                    //If the user chooses to do the fortune teller, and they have not yet had a fortune, then i begin the fortune telling script
                    Console.Clear();
                    Console.WriteLine("You follow the signs to an old inn.\nThe familiar sound of partying spill onto the street as you enter.\nDespite the crowd, you notice a small table, right next to the door, is empty\nexcept for a withered old woman.\nShe sits with her back arched over from strain. Before her are a tarot deck.\nShe notices you looking and beckons you to her with a bony finger.");
                    Console.WriteLine("You sit down at her table and immediatley, the din of the bar begins to fade.\n the old lady speaks, and her you can her her with clarity\neven though she is only whispering.");
                    Game.Dialog("I've been waiting for you" + Player.Playername + ". I will tell you your fortune, no charge.", "darkmagenta");
                    Console.WriteLine("She asks you to shuffle her tarot deck. When you hand it back she flips over the top card.");
                    //The fortune is random
                    switch (rnd.Next(1,5))
                    {
                        case 1:
                            Console.WriteLine("She flips over the Empress card.");
                            Game.Dialog("Ah, the empress. In your time of financial need, you will receive a good fortune.", "darkmagenta");
                            //I use a static bool to keep track of their fortune, so i can use it later
                            fortune = "Empress";
                            break;
                        case 2:
                            Console.WriteLine("She flips over the Lovers card.");
                            Game.Dialog("Ah, the Lovers. Your social encounters will grant you a great fortune!", "darkmagenta");
                            fortune = "Lovers";
                            break;
                        case 3:
                            Console.WriteLine("She flips over the Fool.");
                            Game.Dialog("Ah, the fool. Fitting, don't you agree? This place only marks the beginning of a long journey ahead. Believe in yourself and you will get there.", "darkmagenta");
                            fortune = "Fool";
                            break;
                        case 4:
                            Console.WriteLine("She flips over the hanged man.");
                            Game.Dialog("Oh my. It seems someone has it out for you. I'd beware if i were you.", "darkmagenta");
                            fortune = "Hanged Man";
                            break;
                        case 5:
                            Console.WriteLine("She flips over Death. \nThe sounds of the bar seem to go quiet as the fortune teller considers the card. \nAnticipation hangs in the air. \nFinally the fortune teller breaks the lull.");
                            Game.Dialog("That is not a good sign. I would consider your next few hours carefully.", "darkmagenta");
                            fortune = "Death";
                            break;
                        default:
                            //if the random generator makes a number greater than 5, i have a console write line tell me which switch is having the issue
                            Console.WriteLine("ERROR WITH FORTUNE SWITCH");
                            break;
                        

                    }
                    Console.ReadKey();
                    //set the bool to check if they have already had a fortune to true, so this choice is not the same next time they choose it.
                    secondFortune = true;
                    Console.WriteLine("In a daze you exit the bar. You are considering the consequences of your fortune when you find yourself at another post.");
                    //Add to the night clock
                    Night++;
                }else if(userChoice == "c" && secondFortune)
                {
                    //if they choose the fortune teller when they have already had a fortune, then i run the empty fortune teller script
                    Console.WriteLine("You enter the bar where you had your first fortune told, but the table is no longer empty. \nYou can't seem to find the fortune teller anywhere.");
                    Console.ReadKey();
                    //since nothing really happens, i don't add to the night clock.
                }

                //After 3 choices, night set in the town. I exit this class and jump back to the Game class, where i instantiate the night class
            }

        }


    }
}
