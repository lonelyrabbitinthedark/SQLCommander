using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLCommander.Data;

namespace SQLCommander
{
    public class DatabaseConnection
    {
        private Data.Database _dataBase;
        private string _connectionString;
        private string[] _connectionArguments;

        public DatabaseConnection(Data.Database dataBase, string[] connectionArguments)
        {
            _dataBase = dataBase;
            _connectionArguments = connectionArguments;
        }

        private void BuildConnectionString()
        {
            switch (_dataBase.DatabaseType)
            {
                case DatabaseType.MS_ACCESS:
                    break;
            }
        }

        public Database DataBase
        {
            get { return _dataBase; }
        }

        public string ConnectionString
        {
            get { return _connectionString; }
        }
    }
}
