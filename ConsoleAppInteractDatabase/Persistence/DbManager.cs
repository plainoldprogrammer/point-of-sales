using System;
using ConsoleAppDatabaseAccess.Models;
using ConsoleAppDatabaseAccess.Context;

namespace ConsoleAppDatabaseAccess.Persistence
{
    public class DbManager
    {
        private PointOfSalesContext context;

        public DbManager()
        {
            context = new PointOfSalesContext();
        }

        public void CloseDb()
        {
            context.Dispose();
        }

        public void CreateProduct(string name, int price)
        {
            Product product = new Product()
            {
                Name = name,
                Price = price
            };

            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
