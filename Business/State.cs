using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    abstract class State
    {
        public User user;
        private int karmaPoints;

        public int lowerLimit;
        public int upperLimit;

        public User User
        {
            get { return user; }
            set { user = value;}
        }

        public int KarmaPoints
        {
            get { return karmaPoints; }
            set { karmaPoints = value; }
        }

        public abstract void LikePost(int karmaPoints);
        public abstract void DislikePost(int karmaPoints);

    }
}
