using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ConsoleAppDatabaseAccess.Models;
using ConsoleAppDatabaseAccess.Context;

namespace ConsoleAppDatabaseAccess.Persistence
{
    public class DbManager
    {
        public  PointOfSalesContext context;

        public DbManager()
        {
            context = new PointOfSalesContext();
        }

        public void CloseDb()
        {
            context.Dispose();
        }

        public void CreateProduct(Product product)
        {
            context.Products.Add(product);

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                Console.WriteLine("Product can't be saved on db. Possibly already exists");
            }
        }

        public Product GetProductByName(String name)
        {
            return context.Products.Where(x => x.Name == name).FirstOrDefault()!;
        }
    }
}
