using MattBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Tests.Model
{
    [TestClass]
    public class BankAccount_Tests
    {
        [TestMethod]
        public void AssertThatAccount_InheritsBankName()
        {
            BankAccount account = new BankAccount();
            Assert.AreEqual("Matt's Bank", account.BankName);
        }

        [TestMethod]
        public void AssertThatAccount_HoldsOwnerID()
        {
            BankAccount account = new BankAccount();

            account.OwnerID = 123;

            Assert.AreEqual(123, account.OwnerID);
        }

        [TestMethod]
        public void AssertThatAccount_HoldsAccountBalance()
        {
            BankAccount account = new BankAccount();

            account.AccountBalance = 10000.00f;

            Assert.AreEqual(10000.00f, account.AccountBalance);
        }
    }
}
