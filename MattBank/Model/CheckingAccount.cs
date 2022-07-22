using MattBank.Model.Interface;

namespace MattBank.Model
{
    public class CheckingAccount : Bank, IMoneyAccount
    {
        public long OwnerID { get; set; }

        public float AccountBalance { get; set; }

        public float Deposit(IMoneyAccount account, float depositSum)
        {
            if (depositSum >= 0)
                return account.AccountBalance + depositSum;

            return depositSum;
        }

        public float Withdraw(IMoneyAccount account, float withdrawSum)
        {
            if (account.AccountBalance >= withdrawSum && withdrawSum > 0)
                return account.AccountBalance - withdrawSum;

            return withdrawSum;
        }

        public float Transfer(IMoneyAccount accountFrom, IMoneyAccount AccountTo, float withdrawSum)
        {
            if (accountFrom.AccountBalance >= withdrawSum && withdrawSum > 0)
            {
                accountFrom.AccountBalance -= withdrawSum;
                return AccountTo.AccountBalance += withdrawSum;
            }
            return withdrawSum;
        }
    }
}
