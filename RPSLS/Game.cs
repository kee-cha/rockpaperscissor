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
                else
                {
                    GetNumOfPlayer();
                }
        }

        public void gameStart()
        {
            Console.WriteLine("let's get ready to play ROCK PAPER SCISSOR LIZARD SPOCK!");
            Console.ReadLine();
            string input = GetNumOfPlayer();
            CreatePlayers(input);
            firstPlayer.ChoosePlayerName();
            secondPlayer.ChoosePlayerName();
            firstPlayer.ChooseNumber();
            firstPlayer.PlayerChoice();
            secondPlayer.ChooseNumber();
            secondPlayer.PlayerChoice();
        }

        public void gameRule()
        {
            
        }
    }
}
