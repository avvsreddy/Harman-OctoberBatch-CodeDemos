namespace SimpleCalculatorApp.DataLayer
{
    public class CalculatorRepo
    {
        public static void SaveResult(string result)
        {
            try
            {
                // open db connection
                // write data 1
                // read data
                // update
                // close
                File.WriteAllText(@"d:\data\result.txt", result);
            }
            catch (Exception ex)
            {
                //?????
                // 1. log errors: use some loging frameworks: log4net, serilog, etc

                // 2. translate
                UnableToSaveResultException exp = new UnableToSaveResultException("Not able to save the result", ex);

                // 3. rethrow
                throw exp;
            }
            finally
            {
                // close db connection
            }

        }
    }

    public class UnableToSaveResultException : ApplicationException
    {
        public UnableToSaveResultException(string msg = null, Exception innerExp = null) : base(msg, innerExp)
        {

        }
    }
}
