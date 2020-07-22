using Xunit;
using Demo;
using Moq;

namespace DemoTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckAccountBalance_ReturnAmount()
        {
            var amount = new Account(2000);
            Assert.Equal(1000, amount.Amount);
        }


        [Fact]
        public void WithdrawMoney_ReturnAmount()
        {
            var account = new Account(1000);
            var actual = account.WithdrawMoney(300).Amount;
            Assert.Equal(700, actual);
        }

        [Theory]
        [InlineData(300)]
        [InlineData(200)]
        public void WithdrawMoney_ReturnAmount_SendMultipleInputs(int withdrawenmoney)
        {
            var account = new Account(1000);
            var actual = account.WithdrawMoney(withdrawenmoney);
            Assert.Equal(1000 - withdrawenmoney, actual.Amount);
        }

        [Fact]
        public void CreateClient()
        {
            var client = new Person()
            {
                Name = "Meryem",
                Surname = "Sel",
                ID = "12345"
            };

            var testAddClient = new Client();
            testAddClient.Add(client);

            var addClientMock = new Mock<IPerson>();
            addClientMock.Setup(x => x.CreateClient()).Returns(testAddClient);

            addClientMock.Verify(x => x.CreateClient(), Times.Once);
        }


    }
}
