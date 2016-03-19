namespace TDDSession
{
    public class BankAccount
    {
        private int _balance;

        public int Balance
        {
            get { return _balance; }
        }

        public int CreditBalance(int balance, int amount)
        {
            _balance = balance;
            _balance += amount;
            return _balance;
        }
    }
}