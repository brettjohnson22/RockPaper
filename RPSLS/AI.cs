using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        //member variables (HAS A)
        //list of gestures.
        List<string> gestures;
        //constructor (SPAWNER)
        public AI()
        {
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            this.name = "EDI";
        }
        //member methods (CAN DO)
        //Choose a gesture at random from a list of possible gestures.
        public override string ChooseGesture()
        {
            Random rand = new Random();
            int gestureChoiceIndex = rand.Next(5);
            myChoice = gestures[gestureChoiceIndex];
            return myChoice;
            //throw new NotImplementedException();
        }

    }

}