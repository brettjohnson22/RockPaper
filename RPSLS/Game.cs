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
        public Player firstPlayer;
        public Player secondPlayer;
        


        //constructor (SPAWNER)
        public Game()
        {
            numberOfUsers = DetermineNumberOfUsers();
            CreatePlayers();
            ChooseWhoGoesFirst();
            do
            {
                RunBattle();
            }
            while (playerOne.playerScore > 2 && playerTwo.playerScore > 2);

        }
        //member methods (CAN DO)
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

        public void ChooseWhoGoesFirst()
        {
            Random rand = new Random();
            int whoGoesFirst = rand.Next(2);
            if (whoGoesFirst == 0)
            {
                //PlayerOne goes first
                firstPlayer = playerOne;
                secondPlayer = playerTwo;
                Console.WriteLine($"{playerOne.name} goes first!");
            }
            else
            {
                //PlayerTwo goes first
                firstPlayer = playerTwo;
                secondPlayer = playerOne;
                Console.WriteLine($"{playerTwo.name} goes first!");
            }
        }

        public void RunBattle()
        {
            Battle roundOne = new Battle(firstPlayer, secondPlayer);
        }

        public void GameOver()
        {
            if(playerOne.playerScore == 2)
            {
                Console.WriteLine($"{playerOne.name} is the winner!");
                Console.ReadLine();
            }
            else if(playerTwo.playerScore == 2)
            {
                Console.WriteLine($"{playerTwo.name} is the winner!");
                Console.ReadLine();
            }
        }

    }
}
