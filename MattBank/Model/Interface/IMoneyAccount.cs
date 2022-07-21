namespace MattBank.Model.Interface
{
    public interface IMoneyAccount : IBankAccount
    {
        float Deposit(IMoneyAccount account, float depositSum);
        float Transfer(IMoneyAccount accountFrom, IMoneyAccount AccountTo, float withdrawSum);
        float Withdraw(IMoneyAccount account, float withdrawSum);
    }
}