using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppDatabaseAccess.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public String TicketName { get; set; }

        public Product Product { get; set; }

        [NotMapped]
        public List<Product> Products { get; set; }

        public Ticket()
        {
            Products = new List<Product>();
        }

        [NotMapped]
        public int Total
        {
            get
            {
                int total = 0;

                foreach (Product product in Products)
                {
                    total += product.Price;
                }

                return total;
            }

            set
            {
                Total = value;
            }
        }
    }
}
