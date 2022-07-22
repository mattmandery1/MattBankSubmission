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
