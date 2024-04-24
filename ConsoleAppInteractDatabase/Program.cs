using System;
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

            //dbManager.CreateProduct("bistec", 75);
            //dbManager.CreateProduct("milanesa", 75);
            //dbManager.CreateProduct("caldo", 75);
            //dbManager.CreateProduct("refresco", 25);

            Product product1 = dbManager.GetProduct("refresco");
            Product product2 = dbManager.GetProduct("milanesa");
            dbManager.CreateTicket("Ticket2", new List<Product>() { product1, product2 });

            dbManager.CloseDb();
        }
    }
}
