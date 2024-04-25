using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ConsoleAppDatabaseAccess.Models;

namespace ConsoleAppDatabaseAccess
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int? TicketId { get; set; }

        [ForeignKey("Fk_ProductId")]
        public Product Product { get; set; }
    }
}
