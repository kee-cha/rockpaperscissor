using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public override void ChooseNumber()
        {
            Random cpuChoice = new Random();
             choice = cpuChoice.Next(0,5);
        }

        public override void ChoosePlayerName()
        {
            name = "Computer";
            Console.WriteLine("My name is " + name);
            Console.ReadLine();
            Console.Clear();
        }

        public override void PlayerChoice()
        {
            choose = gestures[choice];
            Console.WriteLine("Second player chooses " + choose);
            Console.ReadLine();
            Console.Clear();
        }
    }
}

  

