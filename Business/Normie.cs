using System;
using System.Collections.Generic;
using System.Text;
using Entity;
namespace Business
{
    class Normie : State
    {
        public Normie(State state)
        {
            this.KarmaPoints = state.KarmaPoints;
            this.user = state.user;
        }

        public override void LikePost()
        {
            karmaPoints += (int)Karma.NormiePoints;
            StateChecker.StateCheck(karmaPoints, (int)Limits.NormieUpperLimit, (int)Limits.NormieLowerLimit,user, this);
        }

        public override void DislikePost()
        {
            karmaPoints -= (int)Karma.NormiePoints;
            StateChecker.StateCheck(karmaPoints, (int)Limits.NormieUpperLimit, (int)Limits.NormieLowerLimit, user, this);
        }

    }
}
        

