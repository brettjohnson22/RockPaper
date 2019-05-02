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
        public abstract string ChooseGesture();
    }
}
