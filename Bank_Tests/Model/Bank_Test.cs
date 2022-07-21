using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MattBank.Model;

namespace Bank_Tests.Model
{
    [TestClass]
    public class Bank_Test
    {
        [TestMethod]
        public void AssertThatBank_HasAName()
        {
            Bank bank = new Bank();
            Assert.AreEqual("Matt's Bank", bank.BankName);
        }
    }
}
