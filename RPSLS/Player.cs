using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public List<string> gestures = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" };
        public int choice;
        public int points;
        public string name;
        public string playerGesture;


        public abstract void ChooseNumber();
        public abstract void ChoosePlayerName();
        public abstract void PlayerChoice();
    }
}
