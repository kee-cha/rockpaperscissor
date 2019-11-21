using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public List<string> gestures = new List<string>() { "rock", "paper", "scissor", "lizard", "spock" };
        public int points;
        public int choice;
    }
}
