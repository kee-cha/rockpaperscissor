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
            Console.WriteLine("How many of players will be playing? 1 or 2");
            string numOfPlayer = Console.ReadLine();
            Console.Clear();
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

        public void gameStart()
        {
            Console.WriteLine("let's get ready to play ROCK PAPER SCISSOR LIZARD SPOCK!");
            Console.ReadLine();
            Console.Clear();
            string input = GetNumOfPlayer();
            CreatePlayers(input);
            firstPlayer.ChoosePlayerName();
            secondPlayer.ChoosePlayerName();
            firstPlayer.ChooseNumber();
            firstPlayer.PlayerChoice();
            secondPlayer.ChooseNumber();
            secondPlayer.PlayerChoice();
        }

        public void GameRule()
        {
            if(firstPlayer.playerGesture == secondPlayer.playerGesture)
            {
                Console.WriteLine("tie");
            }
            else if(firstPlayer.playerGesture == "rock" && (secondPlayer.playerGesture == "scissor" || secondPlayer.playerGesture == "lizard"))
            {
                firstPlayer.points++;
            }
            else if(firstPlayer.playerGesture == "scissor" && (secondPlayer.playerGesture == "paper" || secondPlayer.playerGesture == "lizard"))
            {
                firstPlayer.points++;
            }
            else if(firstPlayer.playerGesture == "paper" && (secondPlayer.playerGesture == "rock" || secondPlayer.playerGesture == "spock"))
            {
                firstPlayer.points++;
            }
            else if(firstPlayer.playerGesture == "lizard" && (secondPlayer.playerGesture == "paper" || secondPlayer.playerGesture == "spock"))
            {
                firstPlayer.points++;
            }
            else if(firstPlayer.playerGesture == "spock" && (secondPlayer.playerGesture == "scissors" || secondPlayer.playerGesture == "rock"))
            {
                firstPlayer.points++;
            }
            else
            {
                secondPlayer.points++;
            }
        }
    }
}
