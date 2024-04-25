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

        public Product? RetrieveProductById(int id)
        {
            return context.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        public Product RetrieveProductByName(String name)
        {
            return context.Products.Where(x => x.Name == name).FirstOrDefault()!;
        }

        public int RetrieveProductsCount()
        {
            return context.Products.Select(x => x).Count();
        }


        public void SaveOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public IEnumerable<Order> RetrieveAllOrders()
        {
            return context.Orders.Select(x => x).Include(x => x.Product);
        }
    }
}
