using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public List<string> selection = new List<string>() { "1", "2", "3", "4", "5" };
        public string validateChoice;
       

        public override void ChooseNumber()
        {
            Console.WriteLine("Enter your number selection from 1 -5." + "\n"
                + " 1: Rock" + "\n"
                + " 2: Paper" + "\n"
                + " 3: Scissor" + "\n"
                + " 4: Lizard" + "\n"
                + " 5: Spock" + "\n");
            validateChoice = Console.ReadLine();
            Console.Clear();

            foreach( string select in selection)
            {
                if(validateChoice == select)
                {
                    choice = Int32.Parse(validateChoice);
                    break;
                }
                else
                {
                    choice = 0;
                }
            }
            
        }

        public override void ChoosePlayerName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.Clear();
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
            Console.Clear();
            
        }
    }
}
