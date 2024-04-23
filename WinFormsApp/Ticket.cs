using System;
using System.Collections.Generic;

namespace WinFormsApp
{
    public class Ticket
    {
        public List<String> Products { get; set; }

        public Ticket()
        {
            Products = new List<String>();
        }
    }
}
