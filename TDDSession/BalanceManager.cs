namespace TDDSession
{
    public class BalanceManager
    {
        private int _balance;

        public int CreditBalance(int balance, int amount)
        {
            _balance = balance;
            _balance += amount;
            return _balance;
        }
    }
}