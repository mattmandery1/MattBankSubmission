using MattBank.Model.Interface;

namespace MattBank.Controller
{
    public class MoneyMoverController
    {
        public float SendDeposit(IMoneyAccount account, float depositSum)
        {
            float response = account.Deposit(account, depositSum);
            return response;
        }

        public float SendWithdraw(IMoneyAccount account, float withdrawSum)
        {
            float response = account.Withdraw(account, withdrawSum);
            return response;
        }

        public float SendTransfer(IMoneyAccount accountFrom, IMoneyAccount accountTo, float transferSum)
        {
            float response = accountFrom.Transfer(accountFrom, accountTo, transferSum);
            return response;
        }
    }
}
