using System;
using SQLCommander.SQL;

namespace SQLer
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var sqlWorker =
                new SqlWorker(
                    new SqlConnector(SqlConnector.DbType.MS_Access, "Connection_String",
                        new[] {"-firstParam", "-secondParam"}),
                    new SqlCommand(SqlCommand.CommandType.Select, "SELECT * FROM Table;"));

            Console.WriteLine(sqlWorker.Connector.FinalConnectionString);
            Console.WriteLine(sqlWorker.Command.CommandText);

            Console.ReadKey();
        }
    }
}