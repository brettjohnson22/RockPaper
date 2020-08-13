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
            else if (playerWhoGoesFirst.myChoice == "rock" && (playerWhoGoesSecond.myChoice == "scissors" || playerWhoGoesSecond.myChoice == "lizard"))
            {
                Console.WriteLine($"{playerWhoGoesFirst.myChoice} beats {playerWhoGoesSecond.myChoice}. {playerWhoGoesFirst.name} wins the round!");
                playerWhoGoesFirst.playerScore++;
            }
            else if (playerWhoGoesFirst.myChoice == "paper" && (playerWhoGoesSecond.myChoice == "rock" || playerWhoGoesSecond.myChoice == "spock"))
            {
                Console.WriteLine($"{playerWhoGoesFirst.myChoice} beats {playerWhoGoesSecond.myChoice}. {playerWhoGoesFirst.name} wins the round!");
                playerWhoGoesFirst.playerScore++;

            }
            else if (playerWhoGoesFirst.myChoice == "scissors" && (playerWhoGoesSecond.myChoice == "paper" || playerWhoGoesSecond.myChoice == "lizard"))
            {

                Console.WriteLine($"{playerWhoGoesFirst.myChoice} beats {playerWhoGoesSecond.myChoice}. {playerWhoGoesFirst.name} wins the round!");
                playerWhoGoesFirst.playerScore++;
            }
            else if (playerWhoGoesFirst.myChoice == "lizard" && (playerWhoGoesSecond.myChoice == "paper" || playerWhoGoesSecond.myChoice == "spock"))
            {
                Console.WriteLine($"{playerWhoGoesFirst.myChoice} beats {playerWhoGoesSecond.myChoice}. {playerWhoGoesFirst.name} wins the round!");
                playerWhoGoesFirst.playerScore++;
            }
            else if (playerWhoGoesFirst.myChoice == "spock" && (playerWhoGoesSecond.myChoice == "scissors" || playerWhoGoesSecond.myChoice == "rock"))
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