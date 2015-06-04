namespace SQLCommander.Data
{
    public class TableColumn : SqlCommander
    {
        private string _name;
        private string _type;

        public TableColumn(string name, string type)
        {
            throw new System.NotImplementedException();
        }

        public string Name
        {
            get { return _name; }
        }

        public string ColumnType
        {
            get { return _type; }
        }
    }
}
