namespace Entity
{
    public class User : BaseClass
    {
        private State _state;
        private string _owner;
        private string username;
        private string firstName;
        private string lastName;
        public string Username { get { return username; } set { username = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public State State { get { return _state; } set { _state = value; } }

     

    }
}
