namespace LanguageEnhancements
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1. local variables type inference
            //2. Object Initialization Syntax
            //3. Anonymous Types
            //4. Lambda Expressions
            //5. Extension Methods

            string data = "some data";
            data.ToUpper();
            data.Encrypt();
            data = Util.Encrypt(data);
            List<int> list = new List<int>();


        }
    }

    public static class Util
    {
        public static string Encrypt(this string data)
        {
            return "@#$@#RFSDFSDDWETR25wegdgsdfgsdfgsd2r5235";
        }
    }



    //class Anonymouse23423423
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Price { get; private set; }
    //}



    //class Product : Object
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Price { get; set; }

    //    //public Product()
    //    //{
    //    //    this.Id = 0;
    //    //    this.Name = null;
    //    //    this.Price = 0;
    //    //}
    //    //public Product(int id, string name, int price):this(id,name)
    //    //{
    //    //    //this.Id = id;
    //    //    //this.Name = name;
    //    //    this.Price = price;
    //    //}
    //    //public Product(int id)
    //    //{
    //    //    this.Id = id;
    //    //}
    //    //public Product(int id, string name):this(id)
    //    //{
    //    //    //this.Id = id;
    //    //    this.Name = name;
    //    //}
    //}
}
