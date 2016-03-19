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

            payerBalance = CreditBalance(payeeBalance, 100);

            int amount = 50;

            payerBalance = CreditBalance(payerBalance, -amount);

            payeeBalance = CreditBalance(payeeBalance, amount);

            Assert.AreEqual(50,payerBalance);

            Assert.AreEqual(50, payeeBalance);
        }

        private static int CreditBalance(int payeeBalance, int amount)
        {
            payeeBalance += amount;
            return payeeBalance;
        }
    }
}
