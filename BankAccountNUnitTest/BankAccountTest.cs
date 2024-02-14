namespace BankAccount.NUnitTest
{
    public class BankAccountTest
    {
        private BankAccounts account = null;
        [SetUp]
        public void Setup()
        {
            account = new BankAccounts();
        }

        [TestCase(500)]
        public void Adding_Funds_Updates_Balance(int amt)
        {
            //ARRANGE
            account = new BankAccounts(1000);

            //ACT
            account.Add(amt);

            //ASSERT
            Assert.AreEqual(1500, account.Balance);
        }
        [Test]
        public void Withdraw_Funds_Updates_Balance()
        {
            //ARRANGE
            account = new BankAccounts(1000);

            //ACT
            account.Withdraw(500);

            //ASSERT
            Assert.AreEqual(500, account.Balance);
        }

        [Test]
        public void Transfer_Funds_To_Other_Account()
        {
            account = new BankAccounts(1000);
            var otherAccount = new BankAccounts();

            account.transferToOtherAccount(otherAccount, 500);
            Assert.AreEqual(500, account.Balance);

            Assert.AreEqual(500, otherAccount.Balance);
        }
    }
}