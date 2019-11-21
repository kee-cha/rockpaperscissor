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
        public int playerChoice;

        public string playerSelection()
        {
            Console.WriteLine("Enter your number selection from 1 -5.");
            validateChoice = Console.ReadLine();
            return validateChoice;
        }

        public override void ChooseChoice()
        {
            foreach( string select in selection)
            {
                if(validateChoice == select)
                {
                    playerChoice = Int32.Parse(validateChoice);
                    break;
                }
                else
                {
                    playerChoice = 0;
                }
            }
        }

        public override void ChoosePlayerName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
        }
    }
}
