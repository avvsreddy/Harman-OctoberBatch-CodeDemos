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
        public virtual List<Supplier> Suppliers { get; set; } = new List<Supplier>();

    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
    }

    public class Supplier : Person
    {
        public string GST { get; set; }
        public int Rating { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
        public Address Address { get; set; }


    }
    [ComplexType]
    public class Address
    {
        public string Area { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
    }

    public abstract class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
    }

    public class Customer : Person
    {
        public int Discount { get; set; }
        public Address Address { get; set; }
    }
}
