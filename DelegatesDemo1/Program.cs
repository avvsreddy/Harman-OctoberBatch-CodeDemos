namespace DelegatesDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Direct Method invocation
            Greeting("Directly");
            // 1. Method Signature with name
            // 2. type of the method - instance/static
            // 3. access specifier - 
            // 4. class
            // 5. namespace
            // 6. project


            // Indirect - use delegates
            // 1. signature
            // 2. address


            // to use delegates
            // 1. declare the delegate
            // 2. instantiate the delegate
            MyDelegate d1 = new MyDelegate(Greeting);
            // 3. initialize the delegate
            // 4. invoke the delegate
            //d1.Invoke("Indirectly");
            d1("using delegates");
            //Delegate d1 = new Delegate();
        }


        public static void Greeting(string text)
        {
            Console.WriteLine($"Greeting: {text}");
        }
    }


    //public class MyDelegate : Delegate
    //{

    //}
    // Delegate Declaration
    public delegate void MyDelegate(string msg);
}
