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
        // TODO: Remove in favor of player member vars
        //public string gesture1;
        //public string playerWhoGoesSecondmyChoice;

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
            playerWhoGoesFirst.ChooseGesture();
            playerWhoGoesSecond.ChooseGesture();
        }

        public void JudgeGestures()
        {
            if (playerWhoGoesFirst.myChoice == playerWhoGoesSecond.myChoice)
            {
                Console.WriteLine("Tied! Try again!");
            }
            else if (playerWhoGoesFirst.myChoice == "rock")
            {
                if (playerWhoGoesSecond.myChoice == "scissors" || playerWhoGoesSecond.myChoice == "lizard")
                {
                    Console.WriteLine($"{playerWhoGoesFirst.myChoice} beats {playerWhoGoesSecond.myChoice}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{playerWhoGoesSecond.myChoice} beats {playerWhoGoesFirst.myChoice}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
            else if (playerWhoGoesFirst.myChoice == "paper")
            {
                if (playerWhoGoesSecond.myChoice == "rock" || playerWhoGoesSecond.myChoice == "spock")
                {
                    Console.WriteLine($"{playerWhoGoesFirst.myChoice} beats {playerWhoGoesSecond.myChoice}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{playerWhoGoesSecond.myChoice} beats {playerWhoGoesFirst.myChoice}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
            else if (playerWhoGoesFirst.myChoice == "scissors")
            {
                if (playerWhoGoesSecond.myChoice == "paper" || playerWhoGoesSecond.myChoice == "lizard")
                {
                    Console.WriteLine($"{playerWhoGoesFirst.myChoice} beats {playerWhoGoesSecond.myChoice}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{playerWhoGoesSecond.myChoice} beats {playerWhoGoesFirst.myChoice}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
            else if (playerWhoGoesFirst.myChoice == "lizard")
            {
                if (playerWhoGoesSecond.myChoice == "paper" || playerWhoGoesSecond.myChoice == "spock")
                {
                    Console.WriteLine($"{playerWhoGoesFirst.myChoice} beats {playerWhoGoesSecond.myChoice}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{playerWhoGoesSecond.myChoice} beats {playerWhoGoesFirst.myChoice}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
            else if (playerWhoGoesFirst.myChoice == "spock")
            {
                if (playerWhoGoesSecond.myChoice == "scissors" || playerWhoGoesSecond.myChoice == "rock")
                {
                    Console.WriteLine($"{playerWhoGoesFirst.myChoice} beats {playerWhoGoesSecond.myChoice}. {playerWhoGoesFirst.name} wins the round!");
                    playerWhoGoesFirst.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{playerWhoGoesSecond.myChoice} beats {playerWhoGoesFirst.myChoice}. {playerWhoGoesSecond.name} wins the round!");
                    playerWhoGoesSecond.playerScore++;
                }
            }
        }
    }
}