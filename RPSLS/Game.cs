using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        Player firstPlayer;
        Player secondPlayer;

        public string GetNumOfPlayer()
        {
            string numOfPlayer = "";
            bool validChoice = false;
            while (!validChoice)
            {
                Console.WriteLine("How many of players will be playing? 1 or 2");
                numOfPlayer = Console.ReadLine();
                Console.Clear();
                switch (numOfPlayer)
                {
                    case "1":
                        validChoice = true;
                        break;
                    case "2":
                        validChoice = true;
                        break;
                    default:
                        break;
                }
            }
            return numOfPlayer;
        }

        public void CreatePlayers(string numOfPlayer)
        {
            if (numOfPlayer == "1")
            {
                firstPlayer = new Human();
                secondPlayer = new Computer();
            }
            else if (numOfPlayer == "2")
            {
                firstPlayer = new Human();
                secondPlayer = new Human();
            }
        }

        public void GameStart()
        {
            Console.WriteLine("let's get ready to play ROCK, PAPER, SCISSOR, LIZARD, SPOCK!");
            Console.ReadLine();
            Console.Clear();
            string input = GetNumOfPlayer();
            CreatePlayers(input);
            firstPlayer.ChoosePlayerName();
            secondPlayer.ChoosePlayerName();
            WinLose();
            Replay();
        }

        public void DisplayWinner()
        {
            Console.WriteLine(firstPlayer.name + " wins this round. Score is: " + firstPlayer.points);
            Console.ReadLine();
            Console.Clear();
        }
        public void GameRule()
        {
            if(firstPlayer.choose == secondPlayer.choose)
            {
                Console.WriteLine("This round is a tie.");
                Console.ReadLine();
                Console.Clear();
            }
            else if(firstPlayer.choose == "rock" && (secondPlayer.choose == "scissor" || secondPlayer.choose == "lizard"))
            {
                firstPlayer.points++;
                DisplayWinner();
            }
            else if(firstPlayer.choose == "scissor" && (secondPlayer.choose == "paper" || secondPlayer.choose == "lizard"))
            {
                firstPlayer.points++;
                DisplayWinner();
            }
            else if(firstPlayer.choose == "paper" && (secondPlayer.choose == "rock" || secondPlayer.choose == "spock"))
            {
                firstPlayer.points++;
                DisplayWinner();
            }
            else if(firstPlayer.choose == "lizard" && (secondPlayer.choose == "paper" || secondPlayer.choose == "spock"))
            {
                firstPlayer.points++;
                DisplayWinner();
            }
            else if(firstPlayer.choose == "spock" && (secondPlayer.choose == "scissor" || secondPlayer.choose == "rock"))
            {
                firstPlayer.points++;
                DisplayWinner();
            }
            else
            {
                secondPlayer.points++;
                Console.WriteLine(secondPlayer.name + " wins this round. Score is: " + secondPlayer.points);
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void GameBattle()
        {
            firstPlayer.ChooseNumber();
            firstPlayer.PlayerChoice();
            secondPlayer.ChooseNumber();
            secondPlayer.PlayerChoice();
            GameRule();
        }

        public void WinLose()
        {
            do
            {
                GameBattle();
            }
            while (firstPlayer.points != 3 && secondPlayer.points != 3);
            Console.WriteLine(firstPlayer.name + ":" + firstPlayer.points + "\n" + secondPlayer.name + ":" + secondPlayer.points);
            Console.ReadLine();
            Console.Clear();
            if (firstPlayer.points == 3)
            {
                Console.WriteLine(firstPlayer.name + " wins the match! Congratulation!!!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine(secondPlayer.name + " wins the match! Congratulation!!!");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void Replay()
        {
            Console.WriteLine("Would you like to play again? Enter yes or no.");
            string reply = Console.ReadLine().ToLower();
            Console.Clear();
            if (reply == "yes" || reply == "y")
            {
                GameStart();
            }
            else if (reply == "no" || reply == "n")
            {
                Console.WriteLine("Thanks for playing.");
                Console.Clear();
            }
            else
            {
                Replay();
            }
        }
    }
}
