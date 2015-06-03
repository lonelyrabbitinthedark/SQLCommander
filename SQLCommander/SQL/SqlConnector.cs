namespace SQLCommander.SQL
{
    /// <summary>
    ///     Represents connection to database
    /// </summary>
    public class SqlConnector
    {
        #region Enums

        /// <summary>
        ///     Database types
        /// </summary>
        public enum DbType
        {
            MS_Access,
            MS_SQL_Server,
            Mysql
        }

        #endregion


        #region Fields

        private readonly string[] _addtionalConnectionParams;
        private readonly string _connectionString;
        private readonly DbType _dataBaseType;
        private readonly string _finalConnectionString;

        #endregion


        #region Constructors

        /// <summary>
        ///     Creates connection to database
        /// </summary>
        /// <param name="dataBaseType">Database type derived to enum DbType from class SqlConnector</param>
        /// <param name="connectionString">Connection text string</param>
        public SqlConnector(DbType dataBaseType, string connectionString)
        {
            _dataBaseType = dataBaseType;
            _connectionString = connectionString;
            _finalConnectionString = _connectionString;
        }

        /// <summary>
        ///     Creates connection to database with additional params
        /// </summary>
        /// <param name="dataBaseType">Database type derived to enum DbType from class SqlConnector</param>
        /// <param name="connectionString">Connection text string</param>
        /// <param name="additionalConnectionParams">Additional connection string params</param>
        public SqlConnector(DbType dataBaseType, string connectionString, string[] additionalConnectionParams)
        {
            _dataBaseType = dataBaseType;
            _connectionString = connectionString;
            _finalConnectionString = _connectionString;
            _addtionalConnectionParams = additionalConnectionParams;
            foreach (var param in _addtionalConnectionParams)
            {
                _finalConnectionString += param;
            }
        }

        #endregion


        #region Properties

        /// <summary>
        ///     Returns database type from enum DbType in class SqlConnector
        /// </summary>
        public DbType DataBaseType
        {
            get { return _dataBaseType; }
        }

        /// <summary>
        ///     Returns array of additional connection params
        /// </summary>
        public string[] AddtionalConnectionParams
        {
            get { return _addtionalConnectionParams; }
        }

        /// <summary>
        ///     Returns text of the connection string
        /// </summary>
        public string FinalConnectionString
        {
            get { return _finalConnectionString; }
        }

        #endregion

    }
}