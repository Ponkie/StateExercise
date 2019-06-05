using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    class GoldUser : State
    {
            public GoldUser(State state)
            {
                this.KarmaPoints = state.KarmaPoints;
            }

            public void Initialize()
            {
                lowerLimit = 10;
                upperLimit = 15;
            }
            public override void LikePost(int karmaPoints)
            {
                karmaPoints += 3;
                StateChangeCheck();
            }


            public override void DislikePost(int karmaPoints)
            {
                karmaPoints -= 3;
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
