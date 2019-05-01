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
        string gesture1;
        string gesture2;

        //constructor (SPAWNER)
        public Battle(Player firstPlayer, Player secondPlayer)
        {
            this.firstPlayer = firstPlayer;
            this.secondPlayer = secondPlayer;

            PromptGestures();
            JudgeGestures();
        }
        //member methods (CAN DO)
        //Compare two gestures and determine a winner.
        //Reprompt players in event of a draw.
        //Feed score to winner.
        //Tell game to trigger next round?

        public void PromptGestures()
        {
            gesture1 = firstPlayer.chooseGesture();
            gesture2 = secondPlayer.chooseGesture();
        }

        public void JudgeGestures()
        {
            if (gesture1 == gesture2)
            {
                //reprompt
            }
            else if (gesture1 == "rock")
            {
                if (gesture2 == "scissors" || gesture2 == "lizard")
                {
                    Console.WriteLine($"{firstPlayer.name} wins!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{secondPlayer.name} wins!");
                    secondPlayer.playerScore++;
                }
            }
            else if (gesture1 == "paper")
            {
                if (gesture2 == "rock" || gesture2 == "spock")
                {
                    Console.WriteLine($"{firstPlayer.name} wins!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{secondPlayer.name} wins!");
                    secondPlayer.playerScore++;
                }
            }
            else if (gesture1 == "scissors")
            {
                if (gesture2 == "paper" || gesture2 == "lizard")
                {
                    Console.WriteLine($"{firstPlayer.name} wins!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{secondPlayer.name} wins!");
                    secondPlayer.playerScore++;
                }
            }
            else if (gesture1 == "lizard")
            {
                if (gesture2 == "paper" || gesture2 == "spock")
                {
                    Console.WriteLine($"{firstPlayer.name} wins!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{secondPlayer.name} wins!");
                    secondPlayer.playerScore++;
                }
            }
            else if (gesture1 == "spock")
            {
                if (gesture2 == "scissors" || gesture2 == "rock")
                {
                    Console.WriteLine($"{firstPlayer.name} wins!");
                    firstPlayer.playerScore++;
                }
                else
                {
                    Console.WriteLine($"{secondPlayer.name} wins!");
                    secondPlayer.playerScore++;
                }
            }
        }
    }
}