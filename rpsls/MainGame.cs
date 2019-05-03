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
        //private int Player1Score = 0;
        //private int Player2Score = 0;
        private int maxScore = 2;


        //spawner
        public MainGame()
        {
            
        }

        //can do
        public void StartGame()
        {
            Console.WriteLine("Welcome To RockPaperScissorsLizardSpock.\nThe Rules are Simple. Scissors cuts Paper, " +
                "Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock,\n Spock smashes Scissors, " +
                "Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock,\n Spock vaporizes Rock " +
                "(and as it always has) Rock crushes Scissors");     
            Console.WriteLine("Lets Play!!");
            Console.ReadKey();
            Console.Clear();

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
                default:
                    Console.WriteLine("Please Choose either 1 or 2");
                    StartGame();
                    break;
            }

            while (Player1.playerScore < maxScore && Player2.playerScore < maxScore) 
            {
                Player1.ChooseGesture();

                Player2.ChooseGesture();

                VictoryConditions();
                Console.Clear();
            }
            if(Player1.playerScore == 2)
            {
                Console.WriteLine("Player 1 wins");
                Console.ReadKey();
                Replay();
            }
            else if(Player2.playerScore == 2)
            {
                Console.WriteLine("Player 2 wins");
                Console.ReadKey();
                Replay();
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
                Player1.playerScore++;
            }
            else if (Player1.gesture == "paper" && Player2.gesture == "rock" ||
                Player1.gesture == "paper" && Player2.gesture == "spock")
            {
                Console.WriteLine("You Win This Round");
                Console.ReadKey();
                Player1.playerScore++;
            }
            else if (Player1.gesture == "scissors" && Player2.gesture == "paper" ||
     Player1.gesture == "scissors" && Player2.gesture == "lizard")
            {
                Console.WriteLine("You Win This Round");
                Console.ReadKey();
                Player1.playerScore++;
            }
            else if (Player1.gesture == "lizard" && Player2.gesture == "paper" ||
     Player1.gesture == "lizard" && Player2.gesture == "spock")
            {
                Console.WriteLine("You Win This Round");
                Console.ReadKey();
                Player1.playerScore++;
            }
            else if (Player1.gesture == "spock" && Player2.gesture == "rock" ||
     Player1.gesture == "spock" && Player2.gesture == "scissors")
            {
                Console.WriteLine("You Win This Round");
                Console.ReadKey();
                Player1.playerScore++;
            }
            else if (Player2.gesture == "rock" && Player1.gesture == "lizard" ||
     Player2.gesture == "rock" && Player1.gesture == "scissors")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2.playerScore++;
            }
            else if (Player2.gesture == "paper" && Player1.gesture == "rock" ||
     Player2.gesture == "paper" && Player1.gesture == "spock")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2.playerScore++;
            }
            else if (Player2.gesture == "scissors" && Player1.gesture == "paper" ||
     Player2.gesture == "scissors" && Player1.gesture == "lizard")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2.playerScore++;
            }
            else if (Player2.gesture == "lizard" && Player1.gesture == "paper" ||
     Player2.gesture == "lizard" && Player1.gesture == "spock")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2.playerScore++;
            }
            else if (Player2.gesture == "spock" && Player1.gesture == "rock" ||
     Player2.gesture == "spock" && Player2.gesture == "scissors")
            {
                Console.WriteLine("You loose this round");
                Console.ReadKey();
                Player2.playerScore++;
            }
            Console.WriteLine("Player 1 Score:" + Player1.playerScore + " " + "Player 2 Score:" + Player2.playerScore);
            Console.ReadKey();
        }
        public void Replay()
        {
            Console.WriteLine("would You Like to play Again?");
            string replaygame;
            replaygame = Console.ReadLine();
            switch (replaygame)
            {
                case "yes":
                    Player1.playerScore = 0;
                    Player2.playerScore = 0;
                    Console.Clear();
                    StartGame();
                    break;
                case "no":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Please Choose Yes or No");
                    Console.ReadKey();
                    Replay();
                    break;
            }
        }
    }
}
