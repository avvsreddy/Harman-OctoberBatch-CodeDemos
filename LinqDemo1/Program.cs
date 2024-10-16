namespace LinqDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Linq to Object
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // extract and display only even numbers

            //table: numbers
            //column:number

            //SQL SELECT: select number from numbers where number mod 2 = 0
            // LINQ Query keywords

            var evens = from i in numbers where i % 2 == 0 select i;
            // LINQ Query with extension methods
            var evens2 = numbers.Where(n => n % 2 == 0);//.Select(n => n);

            //List<int> evens = new List<int>();
            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        evens.Add(i);
            //    }
            //}

            foreach (int i in evens)
            {
                Console.WriteLine(i);
            }
        }
    }
}
