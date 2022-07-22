using MattBank.Model;

namespace MattBank.Model_Tests
{
    [TestClass()]
    public class CheckingAccount_Tests
    {
        [TestMethod()]
        public void AssertThatCheckingAccount_ReturnsCorrectAccountBalance_WhenSuccessfullyAdded()
        {
            float deposit = 1000.00f;
            CheckingAccount account = setBankAccountInfo();

            float balance = account.Deposit(account, deposit);

            Assert.AreEqual(6000.00f, balance);

        }

        [TestMethod()]
        public void AssertThatCheckingAccount_ReturnsSumOfDeposit_WhenNotSuccessfulDueToNegative()
        {
            float deposit = -1000.00f;
            CheckingAccount account = setBankAccountInfo();

            float result = account.Deposit(account, deposit);

            Assert.AreEqual(-1000.00f, result);

        }

        [TestMethod()]
        public void AssertThatCheckingAccount_ReturnsBankName_WhenCheckingAccountIsCreated()
        {
            string expectedValue = "Matt's Bank";

            CheckingAccount account = setBankAccountInfo();

            Assert.AreEqual(expectedValue, account.BankName);

        }

        [TestMethod()]
        public void AssertThatCheckingAccountWithdrawTest_ReturnsCorrectAccountBalance_WhenValidNonNegativeNumberIsPassed()
        {
            float withdrawSum = 1000.00f;
            CheckingAccount account = setBankAccountInfo();

            float balance = account.Withdraw(account, withdrawSum);

            Assert.AreEqual(4000.00f, balance);
        }

        [TestMethod()]
        public void AssertThatCheckingAccountWithdrawTest_ReturnsWithdrawSum_WhenNonvalidNegativeNumberIsPassed()
        {
            float withdrawSum = -1000.00f;
            CheckingAccount account = setBankAccountInfo();

            float result = account.Withdraw(account, withdrawSum);

            Assert.AreEqual(-1000.00f, result);
        }

        [TestMethod()]
        public void AssertThatCheckingAccountWithdrawTest_ReturnsWithdrawSum_WhenWithdrawWouldExceedAccountBalance()
        {
            float withdrawSum = 8000.00f;
            CheckingAccount account = setBankAccountInfo();

            float result = account.Withdraw(account, withdrawSum);

            Assert.AreEqual(8000.00f, result);
        }

        [TestMethod()]
        public void AssertThatCheckingAccountTransferTest_ReturnsWithTransferSumFromAccount_WhenATransferOccurs()
        {
            float transferSum = 1000.00f;
            CheckingAccount account1 = setBankAccountInfo();
            CheckingAccount account2 = setSecondBankAccountInfo();

            float result = account1.Transfer(account1, account2, transferSum);

            Assert.AreEqual(4000.00f, result);
        }

        [TestMethod()]
        public void AssertThatCheckingAccountTransferTest_ReturnsWithTransferSumRequest_WhenATransferOccursWithANegativeTransferSum()
        {
            float transferSum = -1000.00f;
            CheckingAccount account1 = setBankAccountInfo();
            CheckingAccount account2 = setSecondBankAccountInfo();

            float result = account1.Transfer(account1, account2, transferSum);

            Assert.AreEqual(-1000.00f, result);
        }

        private CheckingAccount setBankAccountInfo()
        {
            CheckingAccount account = new CheckingAccount();
            account.AccountBalance = 5000.00f;
            account.OwnerID = 5;
            return account;
        }

        private CheckingAccount setSecondBankAccountInfo()
        {
            CheckingAccount account = new CheckingAccount();
            account.AccountBalance = 3000.00f;
            account.OwnerID = 6;
            return account;
        }
    }
}