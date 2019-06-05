using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    class SilverUser : State
    { 
            public SilverUser(State state)
            {
                this.KarmaPoints = state.KarmaPoints;
            }

            public void Initialize()
            {
                lowerLimit = 6;
                upperLimit = 10;
            }
            public override void LikePost(int karmaPoints)
            {
                karmaPoints += 2;
                StateChangeCheck();
            }


            public override void DislikePost(int karmaPoints)
            {
                karmaPoints -= 2;
                StateChangeCheck();
            }

            public void StateChangeCheck()
            {
                if (KarmaPoints > upperLimit)
                {

                }
            }

        
}
