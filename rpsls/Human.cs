using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpsls
{
    class Human : Player // inheritance (IS A TYPE OF)
    {
        // member variables (HAS A)
        public override void ChooseGesture()
        {
            Console.WriteLine("do you choose Rock, Paper, Scissors, Lizard, or Spock");
            gesture = Console.ReadLine();
            switch (gesture)
            {
            case "rock":
                Console.WriteLine("You Chose Rock");
                break;
            case "paper":
                Console.WriteLine("You Chose Paper");
                break;
            case "scissors":
                Console.WriteLine("You Chose Scissors");
                break;
            case "lizard":
                Console.WriteLine("You Chose Lizard");
                break;
            case "spock":
                Console.WriteLine("You Chose Spock");
                break;
            default:
                Console.WriteLine("You Must Choose One");
                ChooseGesture();
                break;
            }
            Console.ReadLine();
            Console.Clear();
        } 
    }
}