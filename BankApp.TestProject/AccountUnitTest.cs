using Moq;
namespace BankApp.TestProject
{
    //internal class FackNotification : INotification
    //{
    //    public void SendMail(string message)
    //    {
    //        //
    //    }
    //}


    // how to test => AAA
    // What to test => Right BICEP

    [TestClass]
    public class AccountUnitTest
    {
        Account account;
        Mock<INotification> mock;

        [TestInitialize]
        public void Init()
        {
            // execute before every test case

            mock = new Mock<INotification>();
            mock.Setup(m => m.SendMail(""));

            account = new Account(mock.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            // exe after every test case
        }

        [TestMethod]

        [DataRow(1000, 1000)]
        [DataRow(2000, 2000)]
        [DataRow(10000, 10000)]
        public void DepositTest_WithValidInput_ShouldIncreaseTheBalance(int amount, int expected) // +ve Test Case : with valid input, it should increase the balance
        {
            // no conditional statements (if..else..switch..case)
            // no looping statements (for..foreach..while..)
            // no try..catch..finaly

            // only plain code

            // AAA
            // A - Arrange
            //int amount = 1000;
            //Account target = new Account { IsActive = true };
            account.IsActive = true;
            //int expected = 1000;

            // A - Act

            account.Deposit(amount);

            // A - Assert
            Assert.AreEqual(expected, account.Balance);




        }

        [TestMethod]
        [ExpectedException(typeof(AccountNotActiveException))]
        public void DepositTest_WithInactiveAccount_ShouldThrowsExp()
        {
            //Account account = new Account { IsActive = false };
            account.Deposit(1000);
            //
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAmountException))]
        public void DepositTest_WithInvlidAmount_ShouldThrowsExp()
        {
            //Account account = new Account { IsActive = true };
            account.IsActive = true;
            account.Deposit(100);
        }

        [TestMethod]
        public void DepositTest_WithValidInput_ShouldNotify()
        {
            account.IsActive = true;
            account.Deposit(1000);
            mock.Verify(m => m.SendMail("amount deposited"), Times.Once());
        }

    }
}