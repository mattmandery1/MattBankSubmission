using Microsoft.VisualStudio.TestTools.UnitTesting;
using MattBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattBank.Model_Tests
{
    [TestClass()]
    public class InvestmentAccount_Tests
    {
        [TestMethod()]
        public void AssertThatInvestmentAccount_ReturnsCorrectAccountBalance_WhenSuccessfullyAdded()
        {
            float deposit = 1000.00f;
            InvestmentAccount account = setBankAccountInfo();

            float balance = account.Deposit(account, deposit);

            Assert.AreEqual(6000.00f, balance);

        }

        [TestMethod()]
        public void AssertThatInvestmentAccount_ReturnsSumOfDeposit_WhenNotSuccessfulDueToNegative()
        {
            float deposit = -1000.00f;
            InvestmentAccount account = setBankAccountInfo();

            float result = account.Deposit(account, deposit);

            Assert.AreEqual(-1000.00f, result);

        }

        [TestMethod()]
        public void AssertThatInvestmentAccount_ReturnsBankName_WhenInvestmentAccountIsCreated()
        {
            string expectedValue = "Matt's Bank";

            InvestmentAccount account = setBankAccountInfo();

            Assert.AreEqual(expectedValue, account.BankName);

        }

        [TestMethod()]
        public void AssertThatInvestmentAccountWithdrawTest_ReturnsCorrectAccountBalance_WhenValidNonNegativeNumberIsPassed()
        {
            float withdrawSum = 1000.00f;
            InvestmentAccount account = setBankAccountInfo();

            float balance = account.Withdraw(account, withdrawSum);

            Assert.AreEqual(4000.00f, balance);
        }

        [TestMethod()]
        public void AssertThatInvestmentAccountWithdrawTest_ReturnsWithdrawSum_WhenAWithdrawOver500OccursForIndividualAccount()
        {
            float withdrawSum = 1000.00f;
            InvestmentAccount account = setBankAccountInfoForIndividualAccount();

            float result = account.Withdraw(account, withdrawSum);

            Assert.AreEqual(1000.00f, result);
        }

        [TestMethod()]
        public void AssertThatInvestmentAccountWithdrawTest_ReturnsWithdrawSum_WhenNonvalidNegativeNumberIsPassed()
        {
            float withdrawSum = -1000.00f;
            InvestmentAccount account = setBankAccountInfo();

            float result = account.Withdraw(account, withdrawSum);

            Assert.AreEqual(-1000.00f, result);
        }

        [TestMethod()]
        public void AssertThatInvestmentAccountWithdrawTest_ReturnsWithdrawSum_WhenWithdrawWouldExceedAccountBalance()
        {
            float withdrawSum = 8000.00f;
            InvestmentAccount account = setBankAccountInfo();

            float result = account.Withdraw(account, withdrawSum);

            Assert.AreEqual(8000.00f, result);
        }

        [TestMethod()]
        public void AssertThatInvestmentAccountTransferTest_ReturnsWithTransferSumFromAccount_WhenATransferOccurs()
        {
            float transferSum = 1000.00f;
            InvestmentAccount account1 = setBankAccountInfo();
            InvestmentAccount account2 = setSecondBankAccountInfo();

            float result = account1.Transfer(account1, account2, transferSum);

            Assert.AreEqual(4000.00f, result);
        }

        [TestMethod()]
        public void AssertThatInvestmentAccountTransferTest_ReturnsWithTransferSumRequest_WhenATransferOccursWithANegativeTransferSum()
        {
            float transferSum = -1000.00f;
            InvestmentAccount account1 = setBankAccountInfo();
            InvestmentAccount account2 = setSecondBankAccountInfo();

            float result = account1.Transfer(account1, account2, transferSum);

            Assert.AreEqual(-1000.00f, result);
        }

        private InvestmentAccount setBankAccountInfo()
        {
            InvestmentAccount account = new InvestmentAccount();
            account.AccountBalance = 5000.00f;
            account.OwnerID = 5;
            account.IsIndividualAccount = false;
            return account;
        }

        private InvestmentAccount setBankAccountInfoForIndividualAccount()
        {
            InvestmentAccount account = new InvestmentAccount();
            account.AccountBalance = 5000.00f;
            account.OwnerID = 5;
            account.IsIndividualAccount = true;
            return account;
        }

        private InvestmentAccount setSecondBankAccountInfo()
        {
            InvestmentAccount account = new InvestmentAccount();
            account.AccountBalance = 3000.00f;
            account.OwnerID = 6;
            return account;
        }
    }
}