namespace SimpleCalculatorApp.BusinessLayer
{

    /// <summary>
    /// This is used for calculating simple mathematical calculations
    /// </summary>
    public class SimpleCalculator
    {
        /// <summary>
        /// Accepts two non zero postive evens and returns a sum
        /// </summary>
        /// <param name="a">non zero positive even</param>
        /// <param name="b">non zero positive even</param>
        /// <returns>sum</returns>
        /// <exception cref="ZeroInputException"></exception>
        public static int FindSum(int a, int b) // BLL - SRP
        {
            if (a == 0 || b == 0)
            {
                throw new ZeroInputException("Please enter non zero input");
            }

            // save the result into some file
            SimpleCalculatorApp.DataLayer.CalculatorRepo.SaveResult($"{a}+{b}={a + b}");
            return a + b;
        }
    }


    public class ZeroInputException : ApplicationException
    {
        //public ZeroInputException()
        //{

        //}

        //public ZeroInputException(string msg) : base(msg)
        //{
        //    //this.Message = msg;
        //}

        public ZeroInputException(string msg = null, Exception innerEx = null) : base(msg, innerEx)
        {

        }
    }
}
