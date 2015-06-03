using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCommander.Data
{
    public class Database
    {
        private readonly string _dataBasePath;
        private string _dataBaseName;
        private List<DataTable> _tables; 
        private List<User> _users;

        public Database(string dataBasePath)
        {
            _dataBasePath = dataBasePath;
            _users = FetchUsers();
        }

        public List<User> Users
        {
            get { return _users; }
        }

        public string DataBasePath
        {
            get { return _dataBasePath; }
        }

        public string DataBaseName
        {
            get
            {
                var temp = String.Empty;
                for (var i = _dataBasePath.Length - 1; i >= 0; i--)
                {
                    if (_dataBasePath[i] != '\\')
                        temp += _dataBasePath[i];
                    else
                        break;
                }
                for (var i = temp.Length - 1; i >= 0; i--)
                {
                    _dataBaseName += temp[i];
                }
                return _dataBaseName;
            }
        }

        //TODO: Realise method to fetch tables from database
        private List<DataTable> FetchTables()
        {
            _tables = new List<DataTable>();
            return _tables;
        }

        //TODO: Realise method to fetch users from database
        private List<User> FetchUsers()
        {
            _users = new List<User>();
            return _users;
        }
    }
}
