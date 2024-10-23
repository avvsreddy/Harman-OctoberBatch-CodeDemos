using EFDbFirstDemo.Models;

namespace EFDbFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (HarmanOctProductsDbContext db = new HarmanOctProductsDbContext())
            {
                var c = new Customer { };
                db.Customers.Add(c);
                db.SaveChanges();
            }
        }
    }
}
