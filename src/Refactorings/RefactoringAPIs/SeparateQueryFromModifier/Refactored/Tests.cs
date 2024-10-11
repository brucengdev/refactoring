using Moq;

namespace SeparateQueryFromModifier.Refactor
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(PositiveTestCases))]
        public void Can_find_first_miscreant(List<string> people, string message)
        {
            //arrange
            var mockAlarm = new Mock<IAlarm>();
            var mockMessenger = new Mock<IMessenger>();
            var sut = new Monitor(mockAlarm.Object, mockMessenger.Object);

            //act
            sut.PeopleChanged(people);

            //asserts
            mockAlarm.Verify(a => a.Start(), Times.Once);
            mockMessenger.Verify(m => m.SendMessage(It.Is<string>(msg => msg == message)), Times.Once);
        }

        [Theory]
        [MemberData(nameof(NegativeTestCases))]
        public void No_alarm_and_message_when_no_miscreant(List<string> people)
        {
            //arrange
            var mockAlarm = new Mock<IAlarm>();
            var mockMessenger = new Mock<IMessenger>();
            var sut = new Monitor(mockAlarm.Object, mockMessenger.Object);

            //act
            sut.PeopleChanged(people);

            //asserts
            mockAlarm.Verify(a => a.Start(), Times.Never);
            mockMessenger.Verify(m => m.SendMessage(It.IsAny<string>()), Times.Never);
        }

        public static IEnumerable<object[]> PositiveTestCases = new List<object[]>
        {
            new object[] {new List<string>
            {
                "Tom",
                "Jack",
                "Don",
                "Tam"
            }, "Miscreant Don found!"},
            new object[] {new List<string>
            {
                "Tom",
                "Jack",
                "John",
                "Don"
            }, "Miscreant John found!"}
        };

        public static IEnumerable<object[]> NegativeTestCases = new List<object[]>
        {
            new object[] {new List<string>
            {
                "Tom",
                "Jack",
                "Dan",
                "Tam"
            }},
            new object[] {new List<string>
            {
            }}
        };
    }
}