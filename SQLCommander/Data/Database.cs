using System.Collections.Generic;

namespace SQLCommander.Data
{
    public class Database : SqlCommander, IDatabaseWorkingSet
    {
        private List<Table> _tables;
        private List<User> _users;
        private string _name;
        private string _path;
        private DatabaseType _type;

        public Database(string name, string path, DatabaseType type)
        {
            _name = name;
            _path = path;
            _type = type;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Path
        {
            get { return _path; }
        }

        public List<Table> Tables
        {
            get { return _tables; }
        }

        public List<User> Users
        {
            get { return _users; }
        }

        public DatabaseType CurrentDatabaseType
        {
            get { return _type; }
        }

        public DatabaseType DatabaseType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private List<Table> FetchTables()
        {
            throw new System.NotImplementedException();
        }

        private List<User> FetchUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}
