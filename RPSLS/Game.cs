using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables (HAS A)
        public int numberOfUsers;
        public User playerOne;
        public Player playerTwo;
        public string nameInput;
        public Battle roundOne;
        public Battle roundTwo;
        public Battle roundThree;
        

        //constructor (SPAWNER)
        public Game()
        {
            numberOfUsers = DetermineNumberOfUsers();
            CreatePlayers();

           

        }
        //member methods (CAN DO)
        //Run battles.
        //Track score
        //Determine winner of game.
        public int DetermineNumberOfUsers()
        {
            Console.WriteLine("How Many People Are playing? Type '1' or '2'.");
            numberOfUsers = Convert.ToInt32(Console.ReadLine());
            return numberOfUsers;
        }
        
        public void CreatePlayers()
        {
            Console.WriteLine("What is Player One's Name?");
            nameInput = Console.ReadLine();
            playerOne = new User(nameInput);
            if (numberOfUsers == 1)
            {
                playerTwo = new AI();
            }
            else
            {
                Console.WriteLine("What is Player Two's name?");
                nameInput = Console.ReadLine();
                playerTwo = new User(nameInput);
            }
        }
        public void RunBattle()
        {

        }

    }
}
