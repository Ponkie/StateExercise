using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Memento
    {
        private int _karmaPoints;
        private State _state;

        public Memento (int karmaPoints, State state)
        {
            this._karmaPoints = karmaPoints;
            this._state = state;
        }

        public int KarmaPoints { get { return _karmaPoints; } set { _karmaPoints = value; }
        public State State { get { return _state; } set { _state = value; } }
    }
}
