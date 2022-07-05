using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame0._2
{
    class Night
    {
        //This is the value i will reference from the ending class to see which one you got
        public static string ending;

        public Night()
        {
            Console.Clear();
            //This class will determine your ending based on your gold, whether you need to get a hotdog, and what your fortune was.
            string choice;
            Console.WriteLine("You were having so much fun, you didn't even notice the sun set!");
            if (Backpack.Treasure)
            {
                Console.WriteLine("You pass a hotdog stand on your way back.");
                if(Choice3.fortune == "Fool")
                {
                    Console.WriteLine("As you approach the stand, you find it long closed.\nShame flushes your face as you realize that you won't be able to get the guard his hotdog like promised.\nHow could you be so foolish!");
                    Console.WriteLine("Speaking of the devil, you see a familiar grumpy face coming your way.");
                    Game.Dialog("Hey, Buddy! Where's me hotdog!", "red");
                    Console.WriteLine("You try to dash away and lose him in the crowd, but it seems your friend didn't come alone.\nYou dash right into another guardsmen and are promptly arrested.");
                    Console.WriteLine("Your night ends with you sharing a cell with an agressive orc.");
                    ending = "Jail";
                }else if(Choice3.fortune == "Lovers")
                {
                    Console.WriteLine("You rush the stand and catch them as they are beginning to close up.\n The chef seems fed up and ready to close but you begin to explain your situation.\nThe chef seems to know the guard you are talking about!");
                    Game.Dialog("You're talkin about George aren't you! \nHe's my best customer. I was wondering why I didn't see him here today.\nHere, give him this hear dog. \nIt's his favorite!", "darkred");
                    Console.WriteLine("The chef whips you up a hotdog the size of a small dog and hands it to you.\nIf you didn't have to carry this dog with both hands, then youd be wiping the sweat off your forehead.\nJust as you are walking away, there you see George coming your way.\nHis eyes light up at the hotdog in your hands.");
                    Game.Dialog("Well, would you look at that! How'd you know the Orcs colon is my favorite dog!", "red");
                    Console.WriteLine("As you try not to think of the namesake of this particualr dog, George begins to chow down.");
                    Console.WriteLine("You decide to let george have some 'alone time' with his hot dog, and set off to find a comfortable inn you can rest at.");
                    ending = "inn";
                }else
                {
                    Console.WriteLine("You rush the stand and catch them as they are beginning to close up.\n The chef seems fed up and ready to close but offers you a deal.");
                    Game.Dialog("Look, I'll get you a dog, but it's gonna cost you. \nThis last dog's price is gotta be worth the effort we have to put in to heat up the fires again.\nI'm thinking like 20 gold", "darkred");
                    if(Backpack.money == 20)
                    {
                        Console.WriteLine("You look inside your pockets and are able to locate enough gold to just add up to 20./nYou offer it up to the chef. He takes it and begins to make your hotdog.");
                        Console.WriteLine("Just as he finished your hotdog, you notice a familiar grumpy face coming your way. You offer the guard the hotdog, He takes it gleefully.");
                        Game.Dialog("This isn't the best looking dog, but anything tastes good after the day i've had!\nThanks buddy! knew i could rely on you!", "red");
                        if (Choice3.fortune == "Hanged Man")
                        {
                            Game.Dialog("Unfortunatly for you bud, you shouldn't of trusted me.\nSee, my boss heard of what I did, and well, i kinda through you under the cart.\nBut you're smart! i'm sure you'll be fine!\n", "red");
                            Console.WriteLine("He tries to reach for you, but you narrowly avoid him.");
                            Console.WriteLine("You try to dash away and lose him in the crowd, but it seems your friend didn't come alone.\nYou dash right into another guardsmen and are promptly arrested.");
                            Console.WriteLine("Your night ends with you sharing a cell with an agressive orc.");
                            ending = "Jail";
                        }
                        else
                        {
                            Console.WriteLine("The guard saunters off eating his hotdog happily.");
                            Console.WriteLine("You set off into the night, with no money to buy yourself a place to rest.");
                            if (Choice3.fortune == "Empress")
                            {
                                Console.WriteLine("You decide to try your luck at just begging, and find yourself in a small but comfortable gnome inn.\nYou explain the situation and the married gnome couple are glad to take you in.\nThey even bake you some fresh muffins!");
                                ending = "inn";
                            }
                            else
                            {
                                Console.WriteLine("With no inn willing to take you, you exit the town and set up camp.\nAs you are eating rations near the fire, you reflect back on the day.\n'Not bad' you think, 'Not bad'.");
                                ending = "camp";
                            }
                        }
                       
                    }
                    else if(Backpack.money >= 25)
                    {
                        Console.WriteLine("You fish through your bag and find plenty of gold to pay for the hotdog.\nYou hand the man the gold, and he hands you a lackluster hotdog.");
                        Console.WriteLine("you notice a familiar grumpy face coming your way. You offer the guard the hotdog, He takes it gleefully.");
                        if (Choice3.fortune == "Hanged Man")
                        {
                            Game.Dialog("Unfortunatly for you bud, you shouldn't of trusted me.\nSee, my boss heard of what I did, and well, i kinda through you under the cart.\nBut you're smart! i'm sure you'll be fine!\n", "red");
                            Console.WriteLine("He tries to reach for you, but you narrowly avoid him.");
                            Console.WriteLine("You try to dash away and lose him in the crowd, but it seems your friend didn't come alone.\nYou dash right into another guardsmen and are promptly arrested.");
                            Console.WriteLine("Your night ends with you sharing a cell with an agressive orc.");
                            ending = "Jail";
                        }
                        else
                        {
                            Console.WriteLine("You continue on your night, looking for someplace to rest your head.");
                            Console.WriteLine("You find an nice quiet inn, and decide to say there for the night.");
                            ending = "inn";
                        }

                    }
                    else if(Backpack.money > 20&& Backpack.money < 25)
                    {
                        Console.WriteLine("Angrily you fish through you bag. You find enough for the hotdog\nUnfortunatly you won't have enough for a room.");
                        Console.WriteLine("Do you buy the hotdog? (Y/N): ");
                        choice = Console.ReadLine().ToLower();
                        if(choice == "y")
                        {
                            Console.WriteLine("Reluctantly, you hand the man the gold, and he hands you a lackluster hotdog.");
                            Console.WriteLine("you notice a familiar grumpy face coming your way. You offer the guard the hotdog, He takes it gleefully.");
                            Game.Dialog("This isn't the best looking dog, but anything tastes good after the day i've had!\nThanks buddy! knew i could rely on you!\n", "red");
                            if(Choice3.fortune == "Hanged Man")
                            {
                                Game.Dialog("Unfortunatly for you bud, you shouldn't of trusted me.\nSee, my boss heard of what I did, and well, i kinda through you under the cart.\nBut you're smart! i'm sure you'll be fine!\n", "red");
                                Console.WriteLine("He tries to reach for you, but you narrowly avoid him.");
                                Console.WriteLine("You try to dash away and lose him in the crowd, but it seems your friend didn't come alone.\nYou dash right into another guardsmen and are promptly arrested.");
                                Console.WriteLine("Your night ends with you sharing a cell with an agressive orc.");
                                ending = "Jail";
                            }
                            else
                            {
                                Console.WriteLine("The guard saunters off eating his hotdog happily.");
                                Console.WriteLine("You set off into the night, with no money to buy yourself a place to rest.");
                                if (Choice3.fortune == "Empress")
                                {
                                    Console.WriteLine("You decide to try your luck at just begging, and find yourself in a small but comfortable gnome inn.\nYou explain the situation and the married gnome couple are glad to take you in.\nThey even bake you some fresh muffins!");
                                    ending = "inn";
                                }
                                else
                                {
                                    Console.WriteLine("With no inn willing to take you, you exit the town and set up camp.\nAs you are eating rations near the fire, you reflect back on the day.\n'Not bad' you think, 'Not bad'.");
                                    ending = "camp";
                                }
                            }
                            
                        } 
                        else
                        {
                            Game.Dialog("What a sham. No thank you, i'll take my chances elsewhere.\n", "blue");
                            Console.WriteLine("The chef shrugs and you turn around to see a familiar grumpy face coming your way.");
                            Game.Dialog("Hey, Buddy! Where's me hotdog!\n", "red");
                            Console.WriteLine("You try to dash away and lose him in the crowd, but it seems your friend didn't come alone.\nYou dash right into another guardsmen and are promptly arrested.");
                            Console.WriteLine("Your night ends with you sharing a cell with an agressive orc.");
                            ending = "Jail";
                        }

                    }
                    else
                    {
                        Console.WriteLine("You fish around for some gold, but find yourself just short.\nThe chef shrugs.");
                        Game.Dialog("Sorry kid, I'm sure you'll find something else.\n", "darkred");
                        Console.WriteLine("You turn just in time to see a familiar face coming your way.");
                        Game.Dialog("Hey, Buddy! Where's me hotdog!\n", "red");
                        Console.WriteLine("You try to dash away and lose him in the crowd, but it seems your friend didn't come alone.\nYou dash right into another guardsmen and are promptly arrested.");
                        Console.WriteLine("Your night ends with you sharing a cell with an agressive orc.");
                        ending = "Jail";
                    }

                }
            }
            else
            {
                Console.WriteLine("You start to look for inns that could take you in.");
                if (Backpack.money >= 5 && Choice3.fortune != "Hanged Man" && Choice3.fortune != "Death")
                {
                    Console.WriteLine("Eventually you settle on a quiet little in a bit farther in town.");
                    ending = "inn";
                }
                else if (Backpack.money >= 5 && Choice3.fortune == "Hanged Man")
                {
                    Console.WriteLine("You wander into a what you think is a nice inn\nYou buy a room and start to settle down when there is a knock on your door.\nA guard bursts into your room. As he arrests you he claims you were responsible for a murder.\nIn some cruel twist of fate you are carted to jail.");
                    ending = "jail";
                }
                else if (Backpack.money < 5 && Choice3.fortune == "Empress")
                {
                    Console.WriteLine("You decide to try your luck at just begging, and find yourself in a small but comfortable gnome inn.\nYou explain the situation and the married gnome couple are glad to take you in.\nThey even bake you some fresh muffins!");
                    ending = "inn";

                }
                else if (Backpack.money < 5 && Choice3.fortune == "Lovers")
                {
                    Console.WriteLine("You try to find some inn that will take you, but unfortunatly none will.\nYou decide to exit town where you can set up camp, \nBut on your way out you spot the guard from before.\nHe stops you on your way out.");
                    Game.Dialog("Looks like you are down on your luck buddy. How bout you spend the night in the barracks.\nNot the most comfortable, but its much warmer than outside!", "red");
                    Console.WriteLine("You take him up on his offer, and find the barracks to be quite clean and nice!");
                    ending = "inn";
                }
                else
                {
                    Console.WriteLine("You wander from inn to inn, hoping to find one cheap enough, but none will take you.\nYou decide to exit the town and set up camp.;");
                    Console.WriteLine("As you are eating rations near the fire, you reflect back on the day.\n'Not bad' you think, 'Not bad'.");
                    ending = "camp";
                }
            }
        }

        //This returns back to Game class
    }
}
