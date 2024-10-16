namespace LinqDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linq to Objects

            //1. extract all products name only and display

            // SQL Select: select name,price from products;
            var names = from p in Product.GetProducts()
                        select new ProductNameAndPrice { Name = p.Name, Price = p.Price };

            //foreach (var name in names) { Console.WriteLine(name.Name + " " + name.Price); }

            var result = from p in Product.GetProducts()
                         where p.InStock && p.Country == "India"
                         orderby p.Price descending
                         select new { p.Name, p.Price, p.Category };


            // get expensive product name

            var cheapest = (from p in Product.GetProducts()
                            orderby p.Price
                            select p.Name).First();
            Console.WriteLine(cheapest);

            var constliest = (from p in Product.GetProducts()
                              orderby p.Price descending
                              select p.Name).First();
            Console.WriteLine(constliest);
        }
    }


    public class ProductNameAndPrice
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Country { get; set; }
        public bool InStock { get; set; }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
            new Product { Id = 1, Name = "Laptop", Price = 1500, Category = "Electronics", Country = "USA", InStock = true },
            new Product { Id = 2, Name = "Smartphone", Price = 800, Category = "Electronics", Country = "China", InStock = true },
            new Product { Id = 3, Name = "Desk Chair", Price = 200, Category = "Furniture", Country = "Germany", InStock = false },
            new Product { Id = 4, Name = "Running Shoes", Price = 120, Category = "Footwear", Country = "Vietnam", InStock = true },
            new Product { Id = 5, Name = "Coffee Maker", Price = 85, Category = "Kitchen", Country = "Italy", InStock = false },
            new Product { Id = 6, Name = "Gaming Console", Price = 500, Category = "Electronics", Country = "Japan", InStock = true },
            new Product { Id = 7, Name = "Electric Guitar", Price = 750, Category = "Music", Country = "USA", InStock = true },
            new Product { Id = 8, Name = "Mountain Bike", Price = 1300, Category = "Sports", Country = "Canada", InStock = false },
            new Product { Id = 9, Name = "Blender", Price = 65, Category = "Kitchen", Country = "Mexico", InStock = true },
            new Product { Id = 10, Name = "Bookshelf", Price = 150, Category = "Furniture", Country = "Sweden", InStock = true }
            };

            return products;
        }
    }
}
