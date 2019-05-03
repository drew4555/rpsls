using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpsls
{
    public abstract class Player
    {
        //has a
        public List<string> choices;
        public string gesture;
        public int playerScore;
     

        //constructor (spawner)
        public Player()
        {
            choices = new List<string>();
            choices.Add("rock");
            choices.Add("paper");
            choices.Add("scissors");
            choices.Add("lizard");
            choices.Add("spock");
            playerScore = 0;
        }

        //can do
        public abstract void ChooseGesture();
    }
}


        
