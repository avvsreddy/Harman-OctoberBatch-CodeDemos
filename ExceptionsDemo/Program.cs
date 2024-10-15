using SimpleCalculatorApp.BusinessLayer;

namespace ExceptionsDemo
{
    internal class Program // UI
    {
        //SimpleCalculator calculator = new SimpleCalculator();
        static void Main(string[] args) // SRP
        {
            // accept two  non-zero, pasitive, even ints, find the sum then display the result ...repeat

            while (true)
            {
                try
                {
                    int fno, sno, sum;
                    Console.Write("Enter First Number:");
                    fno = int.Parse(Console.ReadLine());
                    Console.Write("Enter Second Number:");
                    sno = int.Parse(Console.ReadLine());

                    sum = SimpleCalculator.FindSum(fno, sno);

                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter only numbers");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Please enter small numbers");
                }
                //catch (SimpleCalculator.BusinessLayer.ZeroInputException ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}

                finally
                {
                    //????
                }
            }


        }


    }
}
