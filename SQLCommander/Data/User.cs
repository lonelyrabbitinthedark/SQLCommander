using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCommander.Data
{
    public class User
    {
        private readonly string _name;
        private readonly string _password;
        private readonly string[] _rights;

        public User(string name, string[] rights)
        {
            _name = name;
            _password = String.Empty;
            _rights = rights;
        }

        public User(string name, string password, string[] rights)
        {
            _name = name;
            _password = password;
            _rights = rights;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Password
        {
            get { return _password; }
        }

        public string[] Rights
        {
            get { return _rights; }
        }
    }
}
