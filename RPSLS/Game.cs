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
            if(numOfPlayer != "1" && numOfPlayer != "2")
            {
                GetNumOfPlayer();
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

        public void gameStart()
        {
            Console.WriteLine("let's get ready to play ROCK PAPER SCISSOR LIZARD SPOCK!");
            Console.ReadLine();
            Console.Clear();
            string input = GetNumOfPlayer();
            CreatePlayers(input);
            firstPlayer.ChoosePlayerName();
            secondPlayer.ChoosePlayerName();
            WinLose();
        }

        public void GameRule()
        {
            if(firstPlayer.playerGesture == secondPlayer.playerGesture)
            {
                Console.WriteLine("This round is a tie.");
                Console.ReadLine();
            }
            else if(firstPlayer.playerGesture == "rock" && (secondPlayer.playerGesture == "scissor" || secondPlayer.playerGesture == "lizard"))
            {
                firstPlayer.points++;
                Console.WriteLine(" First player wins this round. Score is: " + firstPlayer.points);
                Console.ReadLine();
                
            }
            else if(firstPlayer.playerGesture == "scissor" && (secondPlayer.playerGesture == "paper" || secondPlayer.playerGesture == "lizard"))
            {
                firstPlayer.points++;
                Console.WriteLine(" First player wins this round. Score is: " + firstPlayer.points);
                Console.ReadLine();
            }
            else if(firstPlayer.playerGesture == "paper" && (secondPlayer.playerGesture == "rock" || secondPlayer.playerGesture == "spock"))
            {
                firstPlayer.points++;
                Console.WriteLine(" First player wins this round. Score is: " + firstPlayer.points);
                Console.ReadLine();
            }
            else if(firstPlayer.playerGesture == "lizard" && (secondPlayer.playerGesture == "paper" || secondPlayer.playerGesture == "spock"))
            {
                firstPlayer.points++;
                Console.WriteLine(" First player wins this round. Score is: " + firstPlayer.points);
                Console.ReadLine();
            }
            else if(firstPlayer.playerGesture == "spock" && (secondPlayer.playerGesture == "scissor" || secondPlayer.playerGesture == "rock"))
            {
                firstPlayer.points++;
                Console.WriteLine(" First player wins this round. Score is: " + firstPlayer.points);
                Console.ReadLine();
            }
            else
            {
                secondPlayer.points++;
                Console.WriteLine("Second player wins this round. Score is: " + secondPlayer.points);
                Console.ReadLine();
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
            Console.WriteLine("First player points: " + firstPlayer.points + "\n" + "Second player points: " + secondPlayer.points);
            if(firstPlayer.points == 3)
            {
                Console.WriteLine(firstPlayer.name + " wins the match! Congratulation!!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(secondPlayer.name + " wins the match! Congratulation!!!");
                Console.ReadLine();
            }
        }
    }
}
