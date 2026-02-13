using System.ComponentModel.DataAnnotations;

namespace crudgleichchud.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Name { get; set; }
        [Range(0,999999.99)]
        public decimal Price { get; set; }


    }
}
