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
            BankAccount payerAccount = new BankAccount();
            BankAccount payeeAccount = new BankAccount();

            int amount = 50;


            payerAccount.CreditBalance(100);

            BankAccount.TransferFunds(payerAccount, amount, payeeAccount);


            Assert.AreEqual(50, payerAccount.Balance);

            Assert.AreEqual(50, payeeAccount.Balance);
        }
    }
}
