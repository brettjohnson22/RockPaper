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
        public Player playerOne;
        public Player playerTwo;
        public Battle roundOfPlay;
        
        //constructor (SPAWNER)
        public Game()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! By Brett Johnson");
        }

        //member methods (CAN DO)
        public int DetermineNumberOfUsers()
        {
            bool validChoice = false;
            int numberOfUsers = -1;
            while (!validChoice)
            {
                Console.WriteLine("How Many People Are playing? Type '1' or '2'.");
                numberOfUsers = Convert.ToInt32(Console.ReadLine());
                switch (numberOfUsers)
                {
                    case 1:
                        validChoice = true;
                        break;
                    case 2:
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, I can't handle that number of players. Try again.");
                        break;
                }
            }
            return numberOfUsers;
        }
        public void CreatePlayers(int numberOfUsers)
        {
            string nameInput;
            Console.WriteLine("What is Player One's Name?");
            nameInput = Console.ReadLine();
            playerOne = new User(nameInput);
            if (numberOfUsers == 1)
            {
                playerTwo = new AI();
                Console.WriteLine($"{playerOne.name}, you are playing against {playerTwo.name}, an AI.");
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
            Console.WriteLine("Flipping coin to see who goes first...");
            Random rand = new Random();
            int whoGoesFirst = rand.Next(2);
            if (whoGoesFirst == 0)
            {
                playerOne.goingFirst = true;
                Console.WriteLine($"{playerOne.name} goes first!");
            }
            else
            {
                playerTwo.goingFirst = true;
                Console.WriteLine($"{playerTwo.name} goes first!");
            }
        }
        public void RunBattle()
        {
            if (playerOne.goingFirst == true)
            {
                roundOfPlay = new Battle(playerOne, playerTwo);
            }
            else
            {
                roundOfPlay = new Battle(playerTwo, playerOne);
            }
        }
        public void GameOver()
        {
            if(playerOne.playerScore > playerTwo.playerScore)
            {
                Console.WriteLine($"{playerOne.name} is the winner!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} is the winner!");
                Console.ReadLine();
            }
        }
        public void RunGame()
        {
            int numOfUsers = DetermineNumberOfUsers();
            CreatePlayers(numOfUsers);
            ChooseWhoGoesFirst();
            do
            {
                RunBattle();
                Console.WriteLine($"{playerOne.name}: {playerOne.playerScore}. {playerTwo.name}: {playerTwo.playerScore}");
            }
            while (playerOne.playerScore < 2 && playerTwo.playerScore < 2);
            GameOver();
        }

    }
}
