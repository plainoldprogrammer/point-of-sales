using System;
using System.Collections.Generic;

namespace WinFormsApp
{
    public class Ticket
    {
        public List<Product> Products { get; set; }
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
                this.Total = value;
            }
        }

        public Ticket()
        {
            Products = new List<Product>();
        }
    }
}
