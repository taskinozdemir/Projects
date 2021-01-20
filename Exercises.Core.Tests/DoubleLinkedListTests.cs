using Exercises.Core.Common;
using FluentAssertions;
using Xunit;

namespace Exercises.Core.Tests
{
    public class DoubleLinkedListTests
    {
        [Fact]
        public void EmptyInstance_GivenTypeString_ShouldHaveNullValue()
        {
            //DoubleLinkedList<string>.Empty.Value.Should().BeNull("Empty double linked list with type of string should contains null value.");
        }
        [Fact]
        public void EmptyInstance_GivenTypeInteger_ShouldHaveDefaultValue()
        {
            //DoubleLinkedList<int>.Empty.Value.Should().Be(0, "Empty double linked list with type of string should contains null value.");
        }
        [Fact]
        public void Empty_GivenType_ShouldHaveDefaultValue()
        {

            //Moq.Mock<IEsbContext> esbContextMock = GetMockService<IEsbContext>();

            //var prizeDefault = new PrizeDefault();
            //var customerPrizeMessage = new CustomerPrizeMessage();
            //var prizeGroup = new BatchPrizeMessageGroup();
            //customerPrizeMessage.PrizeAction = (int)prizeAction;
            //prizeGroup.Transactions = new List<BatchResultMessage> {
            //    new BatchResultMessage {
            //        CampaignId = 0,
            //        CustomerNo = 0,
            //        ScenarioId = 0,
            //        PhoneNumber = string.Empty
            //    }
            //};

            //Action act = () => prizeDefault.AwardPrize(customerPrizeMessage, prizeGroup);
            //act.Should().NotThrow();
        }
    }
}
