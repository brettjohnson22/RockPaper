using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (HAS A)
        public string name;
        public string myChoice;
        public int playerScore;

        //constructor (SPAWNER)
        public Player()
        {
            playerScore = 0;
        }
        //member methods (CAN DO)
        //Return gesture to battle.
        //Accept new score from battle?
        //Give score to Game to determine winner.
        public abstract string ChooseGesture();
        
    }
}
