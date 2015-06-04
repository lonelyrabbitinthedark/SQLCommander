namespace SQLCommander.Data
{
    public class User : SqlCommander
    {
        private string _name;
        private UserType _type;

        public User(string name, UserType type)
        {
            throw new System.NotImplementedException();
        }

        public string Name
        {
            get { return _name; }
        }

        public UserType TypeOfTheUser
        {
            get { return _type; }
        }

        public UserType UserType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
