using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    class BronzeUser : State
    {

        public BronzeUser(State state)
        {
            this.KarmaPoints = state.KarmaPoints; 
        }

        public void Initialize()
        {
            lowerLimit = 0;
            upperLimit = 5;
        }
        public override void LikePost(int karmaPoints)
        {
            karmaPoints += 1;
            StateChangeCheck();
        }


        public override void DislikePost(int karmaPoints)
        {
            karmaPoints -= 1;
            StateChangeCheck();
        }

        public void StateChangeCheck()
        {
           if (KarmaPoints > upperLimit)
            {
               
            }
        }
    }
}
