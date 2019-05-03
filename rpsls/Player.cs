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
        public List<string> choices = new List<string>();
        public string gesture;
     

        //constructor (spawner)
        public Player()
        {
            choices.Add("rock");
            choices.Add("paper");
            choices.Add("scissors");
            choices.Add("lizard");
            choices.Add("spock");
        }

        //can do
        public abstract void ChooseGesture();
    }
}


        
