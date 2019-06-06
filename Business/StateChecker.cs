using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Business
{
    public class StateChecker 
    {
        public static void StateCheck(int karmaPoints, int upperLimit, int lowerLimit, User user, State state)
        {
            if (state.ToString().Equals("StateExercise.Noob"))
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

            else if (state.ToString().Equals("StateExercise.Normie"))
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

            else if (state.ToString().Equals("StateExercise.TopUser"))
            {
                if (karmaPoints < lowerLimit)
                {
                    user.State = new Normie(state);
                }
            }
        }

    }
}
