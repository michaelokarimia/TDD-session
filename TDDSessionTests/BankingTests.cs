using NUnit.Framework;
using TDDSession;

namespace TDDSessionTests
{
    [TestFixture]
    public class BankingTests
    {
        [Test]
        public void TransferFundsFromPayerToPaye()
        {

            int payerBalance;
            int payeeBalance = 0;

            BankAccount payerAccount = new BankAccount();
            BankAccount payeeAccount = new BankAccount();

            int amount = 50;


            payerBalance =  payerAccount.CreditBalance(payeeBalance, 100);


            payerAccount.CreditBalance(payerBalance, -amount);

            payeeAccount.CreditBalance(payeeBalance, amount);

            Assert.AreEqual(50, payerAccount.Balance);

            Assert.AreEqual(50, payeeAccount.Balance);
        }
        
    }
}
