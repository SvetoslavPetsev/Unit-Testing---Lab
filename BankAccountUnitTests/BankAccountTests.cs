using NUnit.Framework;

namespace BankAccountUnitTests
{
    [TestFixture]
    public class BankAccountTests
    {
        private UnitTesting.BankAccount account;
        [SetUp]
        public void Initialize()
        {
            //Arrange
            this.account = new UnitTesting.BankAccount(2000m);
        }

        [Test]
        public void AccountInitializeWithPositiveValue()
        {
            //Assert
            Assert.That(account.Amount, Is.EqualTo(2000m));
        }
        [Test]
        public void DepositShouldAddMoney()
        {
            //Act
            this.account.Deposit(2000m);
            //Assert
            Assert.That(this.account.Amount, Is.EqualTo(4000));
        }
    }
}
