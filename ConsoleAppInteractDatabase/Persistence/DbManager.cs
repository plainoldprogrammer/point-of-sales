using System;
using Microsoft.EntityFrameworkCore;
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

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine("Product can't be saved on db. Possibly already exists");
            }
        }
    }
}
