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
        Player player1;
        Player player2;


        //spawner
        public MainGame()
        {
            
        }

        //can do
        public void StartGame()
        {
            player1 = new Human();
            Console.WriteLine("How Many Players Are Playing (1 or 2)");
            string starting = Console.ReadLine();
            switch (starting)
            {
                case "1":
                    Player player1 = new Human();
                    Player Computer = new Computer();
                    break;
                case "2":
                    Player human1 = new Human();
                    Player human2 = new Human();
                    break;
            }
                    

            player1.ChooseGesture();
            
            player2.ChooseGesture();

            
        }
        public void VictoryConditions();
        {
        if(Player1)

    }
}
