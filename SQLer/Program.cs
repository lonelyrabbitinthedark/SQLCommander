using System;
using SQLCommander.Data;

namespace SQLer
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Database database = new Database("The Great Database", "C:\\TheGreatDataBase.db", DatabaseType.MYSQL);

            Console.ReadKey();
        }
    }
}