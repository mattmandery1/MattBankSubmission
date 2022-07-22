using MattBank.Model.Interface;

namespace MattBank.Model
{
    public class BankAccount : Bank, IBankAccount
    {
        public long OwnerID { get; set; }
        public float AccountBalance { get; set; }
    }
}
