using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsCatelogApp.Entities
{
    //[Table("tbl_products")]
    public class Product
    {
        //[Key]
        public int ProductId { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        [Required]
        public string Name { get; set; }
        [Column("rate")]
        public int Price { get; set; }
        public bool InStock { get; set; }
        public string Brand { get; set; }
        [NotMapped]
        public int Profit { get; set; }

        public virtual Category Category { get; set; } // lazy loading

    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
