namespace SQLCommander.SQL
{
    /// <summary>
    ///     Represents an object of sql command
    /// </summary>
    public class SqlCommand
    {
        #region Enums
        /// <summary>
        ///     Types of the sql commands
        /// </summary>
        public enum CommandType
        {
            Select,
            Insert,
            Update,
            Delete
        }
        #endregion

        #region Fields

        private readonly string _commandText;
        private readonly CommandType _commandType;

        #endregion


        #region Constructors

        /// <summary>
        ///     Creates an object of sql command from class SqlCommand
        /// </summary>
        /// <param name="commandType">Sql command type derived to enum CommandType from class SqlCommand</param>
        /// <param name="commandText">Text of the sql command</param>
        public SqlCommand(CommandType commandType, string commandText)
        {
            _commandType = commandType;
            _commandText = commandText;
        }

        #endregion


        #region Properties

        /// <summary>
        ///     Returns type of the sql command derived to enum CommandType from class SqlCommand
        /// </summary>
        public CommandType TypeOfCommand
        {
            get { return _commandType; }
        }

        /// <summary>
        ///     Returns text of the sql command
        /// </summary>
        public string CommandText
        {
            get { return _commandText; }
        }

        #endregion

    }
}