using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpsls
{
    class MainGame
    {
        //has a
        private Player Player1;
        private Player Player2;
        private int Player1Score = 0;
        private int Player2Score = 0;
        private int maxScore = 2;


        //spawner
        public MainGame()
        {
            
        }

        //can do
        public void StartGame()
        {
            Console.WriteLine("Welcome To RockPaperScissorsLizardSpock. The Rules are Simple. Scissors cuts Paper, " +
                "Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, " +
                "Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock " +
                "(and as it always has) Rock crushes Scissors");
            Console.WriteLine("Lets Play!!");
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine("How Many rounds would you like to play? (3,5 or 7)");

            Console.WriteLine("How Many Players Are Playing (1 or 2)");
            string starting;
            starting = Console.ReadLine();
            switch (starting)
            {
                case "1":
                    Player1 = new Human();
                    Player2 = new Computer();
                    break;
                case "2":
                    Player1 = new Human();
                    Player2 = new Human();
                    break;
            }

            while (Player1Score < maxScore && Player2Score < maxScore) 
            {
                Player1.ChooseGesture();

                Player2.ChooseGesture();

                VictoryConditions();
                Console.Clear();
            }
            if(Player1Score == 2)
            {
                Console.WriteLine("Player 1 wins");
                Console.ReadKey();
            }
            else if(Player2Score == 2)
            {
                Console.WriteLine("Player 2 wins");
                Console.ReadKey();
            }
        }
        public void VictoryConditions() {

            if (Player1.gesture == Player2.gesture)
            {
                Console.WriteLine("This Round Was a Tie");
                Console.ReadKey();
            }
            else if (Player1.gesture == "rock" && Player2.gesture == "scissors" ||
                    Player1.gesture == "rock" && Player2.gesture == "lizard")
            {
                Console.WriteLine("You Win This Round");
                Console.ReadKey();
                Player1Score++;
            }
            else if (Player1.gesture == "paper" && Player2.gesture == "rock" ||
                Player1.gesture == "paper" && Player2.gesture == "spock")
            {
                Console.WriteLine("You Win This Round");
                Console.ReadKey();
                Player1Score++;
            }
            else if (Player1.gesture == "scissors" && Player2.gesture == "paper" ||
     Player1.gesture == "scissors" && Player2.gesture == "lizard")
            {
                Console.WriteLine("You Win This Round");
                Console.ReadKey();
                Player1Score++;
            }
            else if (Player1.gesture == "lizard" && Player2.gesture == "paper" ||
     Player1.gesture == "lizard" && Player2.gesture == "spock")
            {
                Console.WriteLine("You Win This Round");
                Console.ReadKey();
                Player1Score++;
            }
            else if (Player1.gesture == "spock" && Player2.gesture == "rock" ||
     Player1.gesture == "spock" && Player2.gesture == "scissors")
            {
                Console.WriteLine("You Win This Round");
                Console.ReadKey();
                Player1Score++;
            }
            else if (Player2.gesture == "rock" && Player1.gesture == "lizard" ||
     Player2.gesture == "rock" && Player1.gesture == "scissors")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2Score++;
            }
            else if (Player2.gesture == "paper" && Player1.gesture == "rock" ||
     Player2.gesture == "paper" && Player1.gesture == "spock")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2Score++;
            }
            else if (Player2.gesture == "scissors" && Player1.gesture == "paper" ||
     Player2.gesture == "scissors" && Player1.gesture == "spock")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2Score++;
            }
            else if (Player2.gesture == "lizard" && Player1.gesture == "paper" ||
     Player2.gesture == "lizard" && Player1.gesture == "spock")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2Score++;
            }
            else if (Player2.gesture == "spock" && Player1.gesture == "rock" ||
     Player2.gesture == "spock" && Player2.gesture == "scissors")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2Score++;
            }
            Console.WriteLine("Player 1 Score:" + Player1Score + " " + "Player 2 Score:" + Player2Score);
            Console.ReadKey();
        }
    }
}
