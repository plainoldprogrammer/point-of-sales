using System;
using ConsoleAppDatabaseAccess.Persistence;

namespace ConsoleAppDatabaseAccess
{
    public class Program
    {
        public static void Main(String[] args)
        {
            DbManager dbManager = new DbManager();
            dbManager.CreateProduct("caldo", 75);
            dbManager.CloseDb();
        }
    }
}
