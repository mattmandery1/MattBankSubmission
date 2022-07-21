using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattBank.Model.Interface
{
    public interface IBankAccount
    {
        public long OwnerID { get; set; }
        public float AccountBalance { get; set; }
    }
}
