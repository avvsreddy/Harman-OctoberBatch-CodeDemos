using System.Net.Mail;

namespace BankApp
{
    public class Account
    {
        //public int AccNo { get; set; }
        public int Balance { get; set; }
        public bool IsActive { get; set; }
        //public int Pin { get; set; }


        // 1. active
        // 2. min deposit amount 1000
        // 3. increase the balance
        // 4. notify the customer

        private INotification notification;

        public Account(INotification notification)
        {
            this.notification = notification;
        }
        public void Deposit(int amount)
        {
            if (!this.IsActive)
            {
                throw new AccountNotActiveException("Account is not active for depositing");
            }

            if (amount < 1000)
            {
                throw new InvalidAmountException("Amount should be more or equal to 1000 for deposit");
            }

            Balance += amount;
            // send notification to customer
            //Notification notification = new Notification();
            notification.SendMail("amount deposited");

        }
    }

    public interface INotification
    {
        void SendMail(string message);
    }

    public class Notification : INotification
    {
        public void SendMail(string message)
        {
            SmtpClient smtp = new SmtpClient();
            MailMessage msg = new MailMessage();
            smtp.Send(msg);
        }
    }
}
