using System;

namespace ConsoleAppDatabaseAccess.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public String TicketName { get; set; }

        public Product Product { get; set; }
    }
}
