using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    public class StateChecker 
    {
        public static void NoobStateChecker(int karmaPoints, int upperLimit, int lowerLimit, User user, State state)
        {
            if (karmaPoints > upperLimit)
            {
                user.State = new Normie(state);
            }
            else if (karmaPoints < lowerLimit)
            {
                user.State = new Disabled(state);
            }
        }


        public static void NormieStateChecker(int karmaPoints, int upperLimit, int lowerLimit, User user, State state)
        {
            if (karmaPoints > upperLimit)
            {
                user.State = new TopUser(state);
            }
            else if (karmaPoints < lowerLimit)
            {
                user.State = new Noob(state);
            }
        }

        public static void TopUserStateChecker(int karmaPoints, int upperLimit, int lowerLimit, User user, State state)
        {
            if (karmaPoints < lowerLimit)
            {
                user.State = new Normie(state);
            }
        }

    }
}
