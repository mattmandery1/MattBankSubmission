
namespace MattBank.Model.Interface
{
    public interface IBankAccount
    {
        public long OwnerID { get; set; }
        public float AccountBalance { get; set; }
    }
}
