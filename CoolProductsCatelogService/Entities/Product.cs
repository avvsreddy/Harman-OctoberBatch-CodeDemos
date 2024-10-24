using System.ComponentModel.DataAnnotations;

namespace CoolProductsCatelogService.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Brand { get; set; }
        [Range(1, 10000)]
        public int Price { get; set; }
        public bool InStock { get; set; }
        public string? Country { get; set; }
        public string? Category { get; set; }
    }
}
