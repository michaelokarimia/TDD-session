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

            payerBalance = new BalanceManager().CreditBalance(payeeBalance, 100);

            int amount = 50;

            payerBalance = new BalanceManager().CreditBalance(payerBalance, -amount);

            payeeBalance = new BalanceManager().CreditBalance(payeeBalance, amount);

            Assert.AreEqual(50,payerBalance);

            Assert.AreEqual(50, payeeBalance);
        }
        
    }
}
