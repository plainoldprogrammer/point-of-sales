using System;
using System.Linq;
using System.Collections.Generic;
using ConsoleAppDatabaseAccess.Persistence;
using ConsoleAppDatabaseAccess.Models;

namespace ConsoleAppDatabaseAccess
{
    public class Program
    {
        public static void Main(String[] args)
        {
            DbManager dbManager = new DbManager();

            dbManager.CreateProduct("bistec", 75);
            dbManager.CreateProduct("milanesa", 75);
            dbManager.CreateProduct("caldo", 75);
            dbManager.CreateProduct("refresco", 25);

            //Product product = dbManager.GetProduct("caldo");
            //dbManager.CreateTicket("Ticket1", product);

            dbManager.CloseDb();
        }
    }
}
