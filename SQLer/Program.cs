using System;
using SQLCommander.Data;
using SQLCommander.SQL;

namespace SQLer
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Database database = new Database(Environment.CurrentDirectory + @"\Access.accdb");
            Console.WriteLine(database.DataBasePath);
            Console.WriteLine(database.DataBaseName);

            Console.ReadKey();
        }
    }
}