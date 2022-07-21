using MattBank.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattBank.Model
{
    public class BankAccount : Bank, IBankAccount
    {
        public long OwnerID { get; set; }
        public float AccountBalance { get; set; }
    }
}
