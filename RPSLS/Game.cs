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
        public Battle roundOfPlay;
        public Player playerWhoGoesFirst;
        public Player playerWhoGoesSecond;
        
        //constructor (SPAWNER)
        public Game()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! By Brett Johnson");
            numberOfUsers = DetermineNumberOfUsers();
            CreatePlayers();
            ChooseWhoGoesFirst();
            do
            {
                RunBattle();
                Console.WriteLine($"{playerWhoGoesFirst.name}: {playerWhoGoesFirst.playerScore}. {playerWhoGoesSecond.name}: {playerWhoGoesSecond.playerScore}");
            }
            while (playerWhoGoesFirst.playerScore < 2 && playerWhoGoesSecond.playerScore < 2);
            GameOver();
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
            Random rand = new Random();
            int whoGoesFirst = rand.Next(2);
            if (whoGoesFirst == 0)
            {
                playerWhoGoesFirst = playerOne;
                playerWhoGoesSecond = playerTwo;
                Console.WriteLine($"{playerOne.name} goes first!");
            }
            else
            {
                playerWhoGoesFirst = playerTwo;
                playerWhoGoesSecond = playerOne;
                Console.WriteLine($"{playerTwo.name} goes first!");
            }
        }
        public void RunBattle()
        {
            roundOfPlay = new Battle(playerWhoGoesFirst, playerWhoGoesSecond);
        }
        public void GameOver()
        {
            if(playerWhoGoesFirst.playerScore > playerWhoGoesSecond.playerScore)
            {
                Console.WriteLine($"{playerWhoGoesFirst.name} is the winner!");
                Console.ReadLine();
            }
            else if(playerWhoGoesSecond.playerScore > playerWhoGoesFirst.playerScore)
            {
                Console.WriteLine($"{playerWhoGoesSecond.name} is the winner!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Something else happened.");
                Console.ReadLine();
            }
        }
    }
}
