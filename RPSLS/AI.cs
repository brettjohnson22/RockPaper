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

        //constructor (SPAWNER)
        public AI()
        {
            this.name = "EDI";
        }
        //member methods (CAN DO)
        //Choose a gesture at random from a list of possible gestures.
        public override string chooseGesture()
        {
            throw new NotImplementedException();
        }

    }

}