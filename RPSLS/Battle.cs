using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Battle
    {
        //member variables (HAS A)
        public Player playerWhoGoesFirst;
        public Player playerWhoGoesSecond;
        public string gesture1;
        public string gesture2;

        //constructor (SPAWNER)
        public Battle(Player playerWhoGoesFirst, Player playerWhoGoesSecond)
        {
            this.playerWhoGoesFirst = playerWhoGoesFirst;
            this.playerWhoGoesSecond = playerWhoGoesSecond;

            PromptGestures();
            JudgeGestures();
        }
        //member methods (CAN DO)
        public void PromptGestures()
        {
            gesture1 = playerWhoGoesFirst.ChooseGesture();
            gesture2 = playerWhoGoesSecond.ChooseGesture();
        }

        public void JudgeGestures()
        {
            if (gesture1 == gesture2)
            {
                Console.WriteLine("Tied! Try again!");
            }
            else if (gesture1 == "rock")
            {
                if (gesture2 == "scissors" || gesture2 == "lizard")
                {
                    Console.WriteLine($"{gesture1} beats {gesture2}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
            else if (gesture1 == "paper")
            {
                if (gesture2 == "rock" || gesture2 == "spock")
                {
                    Console.WriteLine($"{gesture1} beats {gesture2}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
            else if (gesture1 == "scissors")
            {
                if (gesture2 == "paper" || gesture2 == "lizard")
                {
                    Console.WriteLine($"{gesture1} beats {gesture2}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
            else if (gesture1 == "lizard")
            {
                if (gesture2 == "paper" || gesture2 == "spock")
                {
                    Console.WriteLine($"{gesture1} beats {gesture2}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
            else if (gesture1 == "spock")
            {
                if (gesture2 == "scissors" || gesture2 == "rock")
                {
                    Console.WriteLine($"{gesture1} beats {gesture2}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
        }
    }
}