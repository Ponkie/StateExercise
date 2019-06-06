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

        public TopUser()
        {
        }

        public override void LikePost()
        {
            karmaPoints += (int)Karma.TopUserPoints;
            StateChecker.StateCheck(karmaPoints, (int)Limits.TopUserUpperLimit, (int)Limits.TopUserLowerLimit, user, this);
        }


        public override void DislikePost()
        {
            karmaPoints -= (int)Karma.TopUserPoints;
            StateChecker.StateCheck(karmaPoints, (int)Limits.TopUserUpperLimit, (int)Limits.TopUserLowerLimit, user, this);
        }

   
    }
}
