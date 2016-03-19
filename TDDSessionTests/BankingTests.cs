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

            int payerBalancer =0;
            int payeeBalance = 0;
            
            payerBalancer += 100;

            int amount = 50;

            payerBalancer -= amount;
            payeeBalance += amount;

            Assert.AreEqual(50,payerBalancer);

            Assert.AreEqual(50, payeeBalance);
        }

    }
}
