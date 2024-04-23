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
                return Products.Count * 30;
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
