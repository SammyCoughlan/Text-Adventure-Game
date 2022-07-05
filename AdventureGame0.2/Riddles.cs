using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AdventureGame0._2
{
    class Riddles
    {
        public string Question;
        public string userInput;
        public static bool win;
        string[] Answers = { "", "", "", "", "", "", "", "" };
        string RiddleOneQuestion = "What animal walks on 3 legs at the bottom of a hill\n2 legs in the middle of the hill\nAnd 3 legs at the top of the hill?";
        string RiddleTwoQuestion = "What has roots that no one sees,\nIs taller than all trees,\nUp and Up it goes,\nAnd yet it never grows?";
        string RiddleThreeQuestion = "Voiceless it cries,\nWingless flutters,\nToothless bites,\nMouthless mutters.";
        string RiddleFourQuestion = "This thing devours all.\nBirds, beasts, trees, flowers\nGnaws iron, bites steel\nGrind hards stones to meal,\nSlays kings, ruins towns\nAnd beats mountains down.";
        string[] RiddleOneAnswers = new string[] { "humans", "people", "homosapiens", "man", "human", "humanity", "humankind", "human kind" };
        string[] RiddleTwoAnswers = new string[] { "mountain", "volcano", "mountains", "volcanoes", "alps", "a very large hill", "large hill", "very large hill" };
        string[] RiddleThreeAnswers = new string[] { "wind", "the wind", "gust", "a gust", "breeze", "a breeze", "gale", "a gale" };
        string[] RiddleFourAnswers = new string[] { "time", "age", "eternity", "lifetime", "aeons", "lifetimes", "life times", "life time" };

        public Riddles(int N)
        {
            switch (N)
            {
                case 1:
                    Question = RiddleOneQuestion;
                    Answers = RiddleOneAnswers;
                    break;
                case 2:
                    Question = RiddleTwoQuestion;
                    Answers = RiddleTwoAnswers;
                    break;
                case 3:
                    Question = RiddleThreeQuestion;
                    Answers = RiddleThreeAnswers;
                    break;
                case 4:
                    Question = RiddleFourQuestion;
                    Answers = RiddleFourAnswers;
                    break;
                default:
                    Debug.Write("The Switch for Riddles has gotten an input not listed", "Urgent");
                    break;

            }
        }

        public void AskRiddle()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(Question);
            Console.ResetColor();
            userInput = Console.ReadLine().ToLower();
            CheckAnswer();
        }

        public void CheckAnswer()
        {
            Console.Clear();
            bool b = Array.Exists(Answers, element => element == userInput);

            if (b)
            {
                Console.WriteLine("The mans eyes light up with surprise!");
                win = true;
            }
            else
            {
                Console.WriteLine("The old man begins to cackle.");
                Game.Dialog("Sorry, little lady, but that isn't right.\n", "orange");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("He patronizes you by listing different forms of the answer he would have accepted.");
                for (int i = 0; i < Answers.Length; i++)
                {
                    Console.WriteLine("\n{0}", Answers[i]);

                }
                Console.ResetColor();
                win = false;

            }
            Console.ReadKey();
        }
    }
}