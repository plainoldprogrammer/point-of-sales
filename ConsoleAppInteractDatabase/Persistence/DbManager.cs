using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ConsoleAppDatabaseAccess.Models;
using ConsoleAppDatabaseAccess.Context;

namespace ConsoleAppDatabaseAccess.Persistence
{
    public class DbManager : IDisposable
    {
        private  PointOfSalesContext context;

        public DbManager()
        {
            context = new PointOfSalesContext();
        }

        public void CloseDb()
        {
            context.Dispose();
        }

        public void Dispose()
        {
            CloseDb();
        }

        public void SaveProduct(Product product)
        {
            try
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                context.Products.Remove(product);
                Console.WriteLine("Product can't be saved on db. Possibly already exists");
            }
        }

        public Product GetProductByName(String name)
        {
            return context.Products.Where(x => x.Name == name).FirstOrDefault()!;
        }

        public Product? GetProductById(int id)
        {
            return context.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        public void CreateOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}
