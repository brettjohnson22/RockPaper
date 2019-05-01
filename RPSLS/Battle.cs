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
        public Player firstPlayer;
        public Player secondPlayer;
        public string gesture1;
        public string gesture2;

        //constructor (SPAWNER)
        public Battle(Player firstPlayer, Player secondPlayer)
        {
            this.firstPlayer = firstPlayer;
            this.secondPlayer = secondPlayer;

            PromptGestures();
            JudgeGestures();
        }
        //member methods (CAN DO)
        public void PromptGestures()
        {
            gesture1 = firstPlayer.ChooseGesture();
            gesture2 = secondPlayer.ChooseGesture();
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
                    Console.WriteLine($"{gesture1} beats {gesture2}. {firstPlayer.name} wins the round!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {secondPlayer.name} wins the round!");
                    secondPlayer.playerScore++;
                }
            }
            else if (gesture1 == "paper")
            {
                if (gesture2 == "rock" || gesture2 == "spock")
                {
                    Console.WriteLine($"{gesture1} beats {gesture2}. {firstPlayer.name} wins the round!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {secondPlayer.name} wins the round!");
                    secondPlayer.playerScore++;
                }
            }
            else if (gesture1 == "scissors")
            {
                if (gesture2 == "paper" || gesture2 == "lizard")
                {
                    Console.WriteLine($"{gesture1} beats {gesture2}. {firstPlayer.name} wins the round!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {secondPlayer.name} wins the round!");
                    secondPlayer.playerScore++;
                }
            }
            else if (gesture1 == "lizard")
            {
                if (gesture2 == "paper" || gesture2 == "spock")
                {
                    Console.WriteLine($"{gesture1} beats {gesture2}. {firstPlayer.name} wins the round!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {secondPlayer.name} wins the round!");
                    secondPlayer.playerScore++;
                }
            }
            else if (gesture1 == "spock")
            {
                if (gesture2 == "scissors" || gesture2 == "rock")
                {
                    Console.WriteLine($"{gesture1} beats {gesture2}. {firstPlayer.name} wins the round!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{gesture2} beats {gesture1}. {secondPlayer.name} wins the round!");
                    secondPlayer.playerScore++;
                }
            }
        }
    }
}