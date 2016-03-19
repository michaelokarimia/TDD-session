namespace TDDSession
{
    public class BalanceManager
    {
        public int CreditBalance(int payeeBalance, int amount)
        {
            payeeBalance += amount;
            return payeeBalance;
        }
    }
}