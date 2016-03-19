namespace TDDSession
{
    public class BankAccount
    {
        private int _balance;

        public int Balance
        {
            get { return _balance; }
        }

        public int CreditBalance(int amount)
        {
            _balance += amount;
            return _balance;
        }

        public static void TransferFunds(BankAccount payerAccount, int amount, BankAccount payeeAccount)
        {
            payerAccount.CreditBalance(-amount);

            payeeAccount.CreditBalance(amount);
        }
    }
}