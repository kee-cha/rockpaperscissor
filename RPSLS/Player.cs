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
        public int points;
        public int choice;
        public string name;
        public string playerGesture;


        public abstract void ChooseChoice();
        public abstract void ChoosePlayerName();
    }
}
