using System.Diagnostics;

namespace SQLCommander.SQL
{
    /// <summary>
    ///     Procceses sql qeuries with database
    /// </summary>
    public class SqlWorker
    {
        #region Fields

        private readonly SqlCommand _sqlCommand;
        private readonly SqlConnector _sqlConnector;

        #endregion


        #region Constructors

        /// <summary>
        ///     Creates sql job for database
        /// </summary>
        /// <param name="sqlConnector">Object of SqlConnector</param>
        /// <param name="sqlCommand">Object of SqlCommand</param>
        public SqlWorker(SqlConnector sqlConnector, SqlCommand sqlCommand)
        {
            _sqlConnector = sqlConnector;
            _sqlCommand = sqlCommand;
        }

        #endregion


        #region Properties

        /// <summary>
        ///     Returns an object of SqlConnector
        /// </summary>
        public SqlConnector Connector
        {
            get { return _sqlConnector; }
        }

        /// <summary>
        ///     Returns an object of SqlCommand
        /// </summary>
        public SqlCommand Command
        {
            get { return _sqlCommand; }
        }

        #endregion


        #region Methods

        /// <summary>
        ///     Determines sql command type and call needed method to proccess it
        /// </summary>
        private void DetermineJob()
        {
            switch (_sqlCommand.TypeOfCommand)
            {
                case SqlCommand.CommandType.Select:
#if DEBUG
                    Debug.Print("Command type: Select");
#endif
                    break;
                case SqlCommand.CommandType.Insert:
#if DEBUG
                    Debug.Print("Command type: Insert");
#endif
                    break;
                case SqlCommand.CommandType.Update:
#if DEBUG
                    Debug.Print("Command type: Update");
#endif
                    break;
                case SqlCommand.CommandType.Delete:
#if DEBUG
                    Debug.Print("Command type: Delete");
#endif
                    break;
            }
        }

        #endregion

    }
}