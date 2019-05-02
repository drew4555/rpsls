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
        public override string ChooseGesture()
        {
            int RandomNumber(int min, int max)
            {
                Random compChoice = new Random();
                compChoice.Next(min, max);

                RandomNumber(0, 4);
                int computerChoice = RandomNumber(0, 4);
                string compPoop;


                if (computerChoice == 0)
                {
                    Console.WriteLine("Your Opponent Chooses Rock");
                    return compPoop = "Rock";
                }
                if (computerChoice == 1)
                {
                    Console.WriteLine("Your Opponent Chooses Paper");
                    return compPoop = "paper";
                }
                if (computerChoice == 2)
                {
                    Console.WriteLine("Your Opponent Chooses Scissors");
                    return compPoop = "Scissors";
                }
                if (computerChoice == 3)
                {
                    Console.WriteLine("Your Opponent Chooses Lizard");
                    return compPoop = "Lizard";
                }
                if (computerChoice == 4)
                {
                    Console.WriteLine("Your Opponent Chooses Spock");
                    return compPoop = "Spock";
                }

            }
        }


    }
}
