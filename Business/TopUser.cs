using Entity;

namespace Business
{
    class TopUser : State
    {
        public TopUser(State state)
        {
            this.KarmaPoints = state.KarmaPoints;
        }

        public TopUser(int karmaPoints, User user)
        {
            this.karmaPoints = karmaPoints;
            this.user = user;
        }

        public override void LikePost()
        {
            karmaPoints += (int)Karma.TopUserPoints;
            StateChangeCheck();
        }


        public override void DislikePost()
        {
            karmaPoints -= (int)Karma.TopUserPoints;
            StateChangeCheck();
        }

        public void StateChangeCheck()
        {
            if (KarmaPoints < (int)Limits.TopUserLowerLimit)
            {
                user.State = new Normie(this);
            }
        }
    }
}
