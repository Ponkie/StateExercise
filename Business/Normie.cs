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
            StateChangeCheck();
        }

        public override void DislikePost()
        {
            karmaPoints -= (int)Karma.NormiePoints;
            StateChangeCheck();
        }

        public void StateChangeCheck()
        {
            if (KarmaPoints > (int)Limits.NormieUpperLimit)
            {
                user.State = new TopUser(this);
            }
            else if (KarmaPoints < (int)Limits.NormieLowerLimit)
            {
                user.State = new Noob(this);
            }
        }
    }
}
        

