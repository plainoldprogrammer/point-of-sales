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

        public Product GetProduct(String name)
        {
            return context.Products.Where(x => x.Name == name).FirstOrDefault()!;
        }

        public void CreateTicket(String ticketName, List<Product> products)
        {
            List<Product> theProdcuts = products;

            foreach (Product product in theProdcuts)
            {
                // It's created a new ticket with same name for each order on the ticket.
                Ticket ticket = new Ticket()
                {
                    TicketName = ticketName,
                    Product = product
                };

                context.Tickets.Add(ticket);
                context.SaveChanges();
            }
        }

        public void SaveTicket(Ticket theTicket)
        {
            String ticketName = theTicket.TicketName;
            List<Product> ticketProducts = theTicket.Products;

            foreach (Product product in ticketProducts)
            {
                Ticket ticket = new Ticket()
                {
                    TicketName = ticketName,
                    Product = product
                };

                context.Tickets.Add(ticket);
                context.SaveChanges();
            }

            Console.WriteLine(theTicket.Total);
        }
    }
}
