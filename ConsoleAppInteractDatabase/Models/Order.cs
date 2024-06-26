﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppDatabaseAccess.Models
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
