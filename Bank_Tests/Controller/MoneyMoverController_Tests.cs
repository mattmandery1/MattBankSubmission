using Microsoft.VisualStudio.TestTools.UnitTesting;
using MattBank.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MattBank.Model.Interface;
using MattBank.Model;

namespace MattBank.Controller_Tests
{
    [TestClass()]
    public class MoneyMoverController_Tests
    {
        //Test only here to demonstrate all types of accounts are handled.

        [TestMethod()]
        public void SendDepositsTest_AssertEngineCanHandleAllAccountTypes()
        {
            List<IMoneyAccount> stressTest = new List<IMoneyAccount>();
            stressTest.Add(new CheckingAccount { AccountBalance = 1000f, OwnerID = 5 });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, IsIndividualAccount = false });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, IsIndividualAccount = true });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5,});

            MoneyMoverController mover = new MoneyMoverController();
            List<float> response = new List<float>();
            foreach (var account in stressTest)
            {
                response.Add(mover.SendDeposit(account, 1000.00f));
            }
            Assert.AreEqual(4, response.Count());
        }

        [TestMethod()]
        public void SendWithdrawsTest_AssertEngineCanHandleAllAccountTypes()
        {
            List<IMoneyAccount> stressTest = new List<IMoneyAccount>();
            stressTest.Add(new CheckingAccount { AccountBalance = 1000f, OwnerID = 5 });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, IsIndividualAccount = false });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, IsIndividualAccount = true });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, });

            MoneyMoverController mover = new MoneyMoverController();
            List<float> response = new List<float>();
            foreach (var account in stressTest)
            {
                response.Add(mover.SendWithdraw(account, 1000.00f));
            }
            Assert.AreEqual(4, response.Count());
        }

        [TestMethod()]
        public void SendTransfersTest_AssertEngineCanHandleAllAccountTypes_SendToChecking()
        {
            CheckingAccount checkingTo = new CheckingAccount();
            checkingTo.AccountBalance = 1000.00f;
            checkingTo.OwnerID = 6;

            List<IMoneyAccount> stressTest = new List<IMoneyAccount>();
            stressTest.Add(new CheckingAccount { AccountBalance = 1000f, OwnerID = 5 });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, IsIndividualAccount = false });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, IsIndividualAccount = true });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, });

            MoneyMoverController mover = new MoneyMoverController();
            List<float> response = new List<float>();
            foreach (var account in stressTest)
            {
                response.Add(mover.SendTransfer(account, checkingTo, 1000.00f));
            }
            Assert.AreEqual(4, response.Count());
        }

        [TestMethod()]
        public void SendTransfersTest_AssertEngineCanHandleAllAccountTypes_SendToInvestment()
        {
            InvestmentAccount checkingTo = new InvestmentAccount();
            checkingTo.AccountBalance = 1000.00f;
            checkingTo.OwnerID = 6;
            checkingTo.IsIndividualAccount = true;

            List<IMoneyAccount> stressTest = new List<IMoneyAccount>();
            stressTest.Add(new CheckingAccount { AccountBalance = 1000f, OwnerID = 5 });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, IsIndividualAccount = false });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, IsIndividualAccount = true });
            stressTest.Add(new InvestmentAccount { AccountBalance = 1000f, OwnerID = 5, });

            MoneyMoverController mover = new MoneyMoverController();
            List<float> response = new List<float>();
            foreach (var account in stressTest)
            {
                response.Add(mover.SendTransfer(account, checkingTo, 1000.00f));
            }
            Assert.AreEqual(4, response.Count());
        }
    }
}