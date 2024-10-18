
namespace BankApp
{
    [Serializable]
    public class AccountNotActiveException : ApplicationException
    {
        public AccountNotActiveException(string? message = null, Exception? innerException = null) : base(message, innerException)
        {
        }
    }
}