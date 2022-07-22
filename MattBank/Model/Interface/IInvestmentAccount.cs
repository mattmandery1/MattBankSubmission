
namespace MattBank.Model.Interface
{
    public interface IInvestmentAccount : IMoneyAccount
    {
        public bool IsIndividualAccount { get; set; }
    }
}
