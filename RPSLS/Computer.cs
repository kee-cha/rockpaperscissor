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
             choice = cpuChoice.Next(1,6);
        }

        public override void ChoosePlayerName()
        {
            Console.WriteLine("My name is Computer");
            name = Console.ReadLine();
        }

        public override void PlayerChoice()
        {
            switch (choice)
            {
                case 1:
                    playerGesture = gestures.ElementAt(0);
                    break;
                case 2:
                    playerGesture = gestures.ElementAt(1);
                    break;
                case 3:
                    playerGesture = gestures.ElementAt(2);
                    break;
                case 4:
                    playerGesture = gestures.ElementAt(3);
                    break;
                case 5:
                    playerGesture = gestures.ElementAt(4);
                    break;
            }
            Console.WriteLine(playerGesture);
            Console.ReadLine();
        }
    }
}

  

