namespace Entity
{
    public abstract class State
    {
        public User user = new User();
        protected int karmaPoints;

        public enum Limits
        {
            NoobLowerLimit = -10,
            NoobUpperLimit = 5,
            NormieLowerLimit = 6,
            NormieUpperLimit = 10,
            TopUserLowerLimit =11,
            TopUserUpperLimit = 100
        }
        public enum Karma
        {
            NoobPoints = 1,
            NormiePoints = 2,
            TopUserPoints = 3
        }

        public int KarmaPoints
        {
            get { return karmaPoints; }
            set { karmaPoints = value; }
        }

        public abstract void LikePost();
        public abstract void DislikePost();

    }
}