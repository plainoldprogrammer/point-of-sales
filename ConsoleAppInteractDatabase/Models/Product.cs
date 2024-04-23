using System.ComponentModel.DataAnnotations;

namespace ConsoleAppDatabaseAccess.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return Name!;
        }
    }
}
