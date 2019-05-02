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
        public bool goingFirst;

        //constructor (SPAWNER)
        public Player()
        {
            playerScore = 0;
            goingFirst = false;
        }
        //member methods (CAN DO)
        public abstract string ChooseGesture();
    }
}
