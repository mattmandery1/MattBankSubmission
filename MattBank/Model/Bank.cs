using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattBank.Model
{
    public class Bank
    {
        public string BankName { get; protected set; } = "Matt's Bank"; //Believed to only ever be our bank so hard coded and passed as a dependency
    }
}
