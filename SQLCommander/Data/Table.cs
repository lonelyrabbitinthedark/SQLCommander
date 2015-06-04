using System.Collections.Generic;

namespace SQLCommander.Data
{
    public class Table : SqlCommander
    {
        private string _name;
        private List<TableColumn> _columns;

        public string Name
        {
            get { return _name; }
        }

        public List<TableColumn> Columns
        {
            get { return _columns; }
        }

        private void GetColumns()
        {
            throw new System.NotImplementedException();
        }
    }
}
