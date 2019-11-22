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

            if(selection.Contains(validateChoice))
            {
                choice = Int32.Parse(validateChoice);
            }
            else
            {
                ChooseNumber();
            }
        }

        public override void ChoosePlayerName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine().ToUpper();
            Console.Clear();
        }
        public override void PlayerChoice()
        {
            choose = gestures[choice - 1];
            Console.WriteLine(choose);
            Console.Clear();
        }
    }
}
