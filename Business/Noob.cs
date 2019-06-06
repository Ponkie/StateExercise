using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    class Noob : State
    {

        public Noob(State state) :
         this(state.KarmaPoints, state.user)
        {
        }

        public Noob(int karmaPoints, User user)
        {
            this.karmaPoints = karmaPoints;
            this.user = user;
        }


        public override void LikePost()
        {
            karmaPoints += (int)Karma.NoobPoints;
            StateChecker.NoobStateChecker(karmaPoints, (int)Limits.NoobUpperLimit, (int)Limits.NoobLowerLimit, user, this);
        }


        public override void DislikePost()
        {
            karmaPoints -= (int)Karma.NoobPoints;
            StateChecker.NoobStateChecker(karmaPoints, (int)Limits.NoobUpperLimit, (int)Limits.NoobLowerLimit, user, this);
        }

    
    }
}
