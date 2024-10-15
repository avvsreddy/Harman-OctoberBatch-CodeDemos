namespace DelegatesDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.alert += Notification.SendEmail; //sub
            account.alert += Notification.SendSMS; //sub

            //account.alert -= Notification.SendEmail; //unsub
            //account.Deposit(5000);
            //account.alert("Your account has been incread by $9999999999999.99");
            Console.WriteLine(account.Balance);

            //account.Withdraw(1000);

            Console.WriteLine(account.Balance);
        }
    }

    public delegate void AlertDelegate(string msg);
    public class Account
    {
        public int Balance { get; private set; }
        public event AlertDelegate alert = null; //new AlertDelegate(Notification.SendEmail);
        public void Deposit(int amount)
        {
            Balance += amount;
            if (alert != null)
            {
                alert($"Your account has been increased by {amount}");
            }
            //Notification.SendEmail($"Your account has been increased by {amount}");
            //Notification.SendSMS($"Your account has been increased by {amount}");
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
            if (alert != null)
            {
                alert($"Your account has been decreased by {amount}");
            }
            // write a code to send email
            //Notification.SendEmail($"Your account has been decreased by {amount}");
            //Notification.SendSMS($"Your account has been decreased by {amount}");
        }
    }



    class Notification
    {
        public static void SendEmail(string msg)
        {
            // write a code to send email
            //SmtpClient client = new SmtpClient();
            //client.Send()
            Console.WriteLine($"Mail: {msg}");
        }

        public static void SendSMS(string msg)
        {
            // write a code to send email
            //SmtpClient client = new SmtpClient();
            //client.Send()
            Console.WriteLine($"SMS: {msg}");
        }
    }
}
