using System;
using System.Collections.Generic;
using ConsoleAppDatabaseAccess.Persistence;
using ConsoleAppDatabaseAccess.Models;
using System.Linq;

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

            //Product product1 = dbManager.GetProduct("refresco");
            //Product product2 = dbManager.GetProduct("milanesa");
            //dbManager.CreateTicket("Ticket2", new List<Product>() { product1, product2 });

            //Ticket ticket = new Ticket();
            //ticket.TicketName = "Ticket3";
            //ticket.Products.Add(dbManager.GetProduct("bistec"));
            //ticket.Products.Add(dbManager.GetProduct("refresco"));

            //dbManager.SaveTicket(ticket);

            Product product = new Product();
            product = dbManager.context.Products.Where(x => x.Name == "milanesa").FirstOrDefault();

            Order order = new Order();
            order.Id = 1;
            order.TicketName = "Ticket1";
            order.Product = product;

            dbManager.context.Orders.Add(order);
            dbManager.context.SaveChanges();

            dbManager.CloseDb();
        }
    }
}
