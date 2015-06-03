using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCommander.Data
{
    class DataTable
    {
        private readonly string _tableName;
        private readonly Database _database;
        private readonly string _owner;

        public DataTable(string tableName)
        {
            _tableName = tableName;
        }
    }
}
