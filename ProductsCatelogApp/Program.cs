using ProductsCatelogApp.Data;
using ProductsCatelogApp.Entities;

namespace ProductsCatelogApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ProductsDbContext db = new ProductsDbContext())
            {
                // get all products with categories and display
                var allProducts = from p in db.Products//.Include(p => p.Category)
                                  select p;

                foreach (var item in allProducts)
                {
                    Console.WriteLine(item.Name + "\t" + item.Category.CategoryName);
                }
            }
        }














        private static void addproductwithcat(ProductsDbContext db)
        {
            // Add a new product with new category
            var c = new Category { CategoryName = "Mobiles" };
            var p = new Product { Brand = "Apple", Category = c, InStock = true, Name = "I Phone 15", Price = 89000 };


            db.Products.Add(p);
            //db.Categories.Add(c);
            db.SaveChanges();
        }

        private static void update()
        {
            using (ProductsDbContext db = new ProductsDbContext())
            {
                // get the product to delete
                // delete the product
                var productToDelete = db.Products.Find(1);
                //var productToDelete2 = db.Products.Find(1);
                db.Products.Remove(productToDelete);
                db.SaveChanges();
            }
        }

        private static void upate()
        {
            using (
            ProductsDbContext db = new ProductsDbContext())
            {

                // need to increase the first productid 1 price
                //1. get the product which you want to update
                var productToUpdate = (from p in db.Products
                                       where p.ProductId == 1
                                       select p).FirstOrDefault();

                productToUpdate.Price += 100;
                db.SaveChanges();
                //db.Dispose();
            }
            //db.Database.ExecuteSqlRaw("update products set price = price + 100 where productid=2");
        }

        private static void select(ProductsDbContext db)
        {
            // get all products
            // linq to entities
            var allProducts = from p in db.Products
                              select p;

            foreach (var product in allProducts)
            {
                Console.WriteLine(product.ProductId + "\t" + product.Name + "\t" + product.Price);
            }
        }

        private static void Add(ProductsDbContext db)
        {
            Product p = new Product { Name = "Galaxy S24", Price = 85000 };
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("saved");
        }
    }
}
