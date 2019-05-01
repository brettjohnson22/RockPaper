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
        public Battle()
        {

        }
        //member methods (CAN DO)
        //Compare two gestures and determine a winner.
        //Reprompt players in event of a draw.
        //Feed score to winner.
        //Tell game to trigger next round?

        public void PromptGestures()
        {
            Console.WriteLine($"{firstPlayer.name} please enter your gesture: rock/paper/scissors/lizard/spock");
            gesture1 = Console.ReadLine();
            Console.WriteLine($"{secondPlayer.name} please enter your gesture: rock/paper/scissors/lizard/spock);
        }

        //public judgeGestures()
        //{
        //    if (gesture1 == gesture2)
        //    {
        //        //reprompt
        //    }
        //    else if (gesture1 == rock)
        //    {
        //        if (gesture2 == scissors || gesture2 == lizard)
        //        {
        //            playerOne wins;
        //        }
        //        else
        //        {
        //            playerTwo wins;
        //        }
        //    }
        //    else if (gesture1 == paper)
        //    {
        //        if (gesture2 == rock || gesture2 == spock)
        //        {
        //            playerOne wins;
        //        }
        //        else
        //        {
        //            playerTwo wins;
        //        }
        //    }
        //    else if (gesture1 == scissors)
        //    {
        //        if (gesture2 == paper || gesture2 == lizard)
        //        {
        //            playerOne wins;
        //        }
        //        else
        //        {
        //            playerTwo wins;
        //        }
        //    }
        //    else if (gesture1 == lizard)
        //    {
        //        if (gesture2 == paper || gesture2 == spock)
        //        {
        //            playerOne wins;
        //        }
        //        else
        //        {
        //            playerTwo wins;
        //        }
        //    }
        //    else if (gesture1 == spock)
        //    {
        //        if (gesture2 == scissors || gesture2 == rock)
        //        {
        //            playerOne wins;
        //        }
        //        else
        //        {
        //            playerTwo wins;
        //        }
        //    }
        //}
    }
}