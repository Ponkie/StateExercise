using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    class Disabled : State

    {

        public Disabled(int karmaPoints, User user)
        {
            this.karmaPoints = karmaPoints;
            this.user = user;
        }

        public Disabled(State state) : this(state.KarmaPoints, state.user)
        {
        }


        public override void LikePost()
        {
            StateChangeCheck();
        }

        public override void DislikePost()
        {
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {

        }
    }
}
