namespace LinqDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 32, 3, 14, 5, 56, 7, 8, 39 };



            //numbers.Add(10);
            //var evens = GetEvenNumbers(numbers);
            var evens = (from n in numbers
                         where IsEven(n)
                         orderby n descending
                         select n).ToList();

            var evens2 = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n).ToList();

            foreach (var e in evens)
            {
                Console.WriteLine(e);
            }
        }

        public static bool IsEven(int n)
        {
            Console.WriteLine("IS Even called");
            return (n % 2 == 0);
        }

        //static List<int> GetEvenNumbers(List<int> numbers)
        //{
        //    var evens = (from n in numbers
        //                 where n % 2 == 0
        //                 select n).ToList();
        //    Console.WriteLine("In Get even numbers method");
        //    return evens;
        //}
    }
}
