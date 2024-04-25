using System;
using System.Collections.Generic;
using ConsoleAppDatabaseAccess.Persistence;
using ConsoleAppDatabaseAccess.Models;
using System.Linq;

namespace ConsoleAppDatabaseAccess
{
    public class Program
    {
        private static DbManager dbManager;

        public static void Main(String[] args)
        {
            using (dbManager = new DbManager())
            {
                Test_Method_001_Create_Products();
                Test_Method_002_Create_Order();
            }
        }

        public static void Test_Method_001_Create_Products()
        {
            dbManager.SaveProduct(new Product() { Name = "bistec", Price = 75 });
            dbManager.SaveProduct(new Product() { Name = "milanesa", Price = 75 });
            dbManager.SaveProduct(new Product() { Name = "caldo", Price = 75 });
            dbManager.SaveProduct(new Product() { Name = "refresco", Price = 25 });
        }

        public static void Test_Method_002_Create_Order()
        {
            Product? product = new Product();
            product = dbManager.GetProductByName("milanesa");

            Order order = new Order();
            order.TicketName = "Ticket1";
            order.Product = product!;

            dbManager.SaveOrder(order);
        }
    }
}
