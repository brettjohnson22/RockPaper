using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class User : Player
    {
        //member variables (HAS A)
        
        //constructor (SPAWNER)
        public User(string name)
        {
            this.name = name;
        }
        //member methods (CAN DO)
        public override string ChooseGesture()
        {
            bool validChoice = false;
            while (!validChoice)
            { 
                Console.WriteLine($"{name}, choose a gesture: rock/paper/scissors/lizard/spock");
                Console.ForegroundColor = ConsoleColor.Black;
                myChoice = Console.ReadLine().ToLower();
                switch (myChoice)
                {
                    case "rock":
                        validChoice = true;
                        break;
                    case "paper":
                        validChoice = true;
                        break;
                    case "scissors":
                        validChoice = true;
                        break;
                    case "lizard":
                        validChoice = true;
                        break;
                    case "spock":
                        validChoice = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Try again.");
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            return myChoice;
        }
    }
}
