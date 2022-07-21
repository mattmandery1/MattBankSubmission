using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattBank.Model.Interface
{
    public interface IInvestmentAccount : IMoneyAccount
    {
        public bool IsIndividualAccount { get; set; }
    }
}
