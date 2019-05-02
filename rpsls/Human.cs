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
        public override string ChooseGesture()
        {
            Console.WriteLine("do you choose Rock, Paper, Scissors, Lizard, or Spock");
            string UserChoice = Console.ReadLine();
            switch (UserChoice)
            {
                case "Rock":
                    Console.WriteLine("You Chose Rock");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "Paper":
                    Console.WriteLine("You Chose Paper");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "Scissors":
                    Console.WriteLine("You Chose Scissors");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "Lizzard":
                    Console.WriteLine("You Chose Lizoard");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "Spock":
                    Console.WriteLine("You Chose Spock");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("You Must Choose One");
                    Console.ReadLine();
                    Console.Clear();
                    break;

            }
        }
    }
}