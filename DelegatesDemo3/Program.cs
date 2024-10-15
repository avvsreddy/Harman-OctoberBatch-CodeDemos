namespace DelegatesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int sum = 0;
            //foreach (int i in list)
            //{
            //    if (i % 2 == 0)
            //        sum += i;
            //}
            //Console.WriteLine(sum);'

            Func<int, bool> filter = new Func<int, bool>(IsEven);

            int sum = list.Where(filter).Sum();
            Console.WriteLine(sum);

            sum = list.Where(delegate (int n)
            {
                return n % 2 == 0;
            }).Sum();

            sum = list.Where((int n) =>
            {
                return n % 2 == 0;
            }).Sum();

            sum = list.Where((int n) =>
                 n % 2 == 0
            ).Sum();

            sum = list.Where(n => n % 2 == 0).Sum();


        }
        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }


}
