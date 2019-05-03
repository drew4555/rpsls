using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpsls
{
    class Computer : Player
    {



        // member methods (CAN DO)

        //random choice
        private int RandomNumber(int min, int max)
        {
            Random compChoice = new Random();
            int randomNumber = compChoice.Next(min, max);
            return randomNumber;
        }
        public override void ChooseGesture()
        {
            int computerChoice = RandomNumber(0, 4);

            

                if (computerChoice == 0)
                {
                Console.WriteLine("Your Opponent Chooses Rock");
                Console.ReadKey();
                Console.Clear();
                }
                if (computerChoice == 1)
                {
                Console.WriteLine("Your Opponent Chooses Paper");
                Console.ReadKey();
                Console.Clear();
            }
                if (computerChoice == 2)
                {
                Console.WriteLine("Your Opponent Chooses Scissors");
                Console.ReadKey();
                Console.Clear();
            }
                if (computerChoice == 3)
                {
                Console.WriteLine("Your Opponent Chooses Lizard");
                Console.ReadKey();
                Console.Clear();
            }
                if (computerChoice == 4)
                {
                Console.WriteLine("Your Opponent Chooses Spock");
                Console.ReadKey();
                Console.Clear();
            }
            gesture = choices[computerChoice];
        }


    }
}
