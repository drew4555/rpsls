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
            choices.Add("Rock");
            choices.Add("Paper");
            choices.Add("Scissors");
            choices.Add("Lizard");
            choices.Add("Spock");
        }

        //can do
        public abstract string ChooseGesture();
    }
}


        
