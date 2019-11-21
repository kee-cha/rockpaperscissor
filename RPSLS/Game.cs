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
            Console.WriteLine("How many of players? 1 or 2");
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
            string input = GetNumOfPlayer();
            CreatePlayers(input);
            firstPlayer.ChooseChoice();
            secondPlayer.ChooseChoice();
        }
    }
}
