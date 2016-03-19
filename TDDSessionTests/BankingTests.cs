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

            int payerBalance =0;
            int payeeBalance = 0;

            BankAccount payerAccount = new BankAccount();
            payerBalance =  payerAccount.CreditBalance(payeeBalance, 100);

            int amount = 50;

            payerBalance = payerAccount.CreditBalance(payerBalance, -amount);

            BankAccount payeeAccount = new BankAccount();
            payeeBalance = payeeAccount.CreditBalance(payeeBalance, amount);

            Assert.AreEqual(50,payerBalance);

            Assert.AreEqual(50, payeeBalance);
        }
        
    }
}
