using Shouldly;

namespace ParameterizeFunction.Refactored
{
    public class Tests
    {
        [Fact]
        public void TestBaseCharge()
        {
            var sut = new ChargeCalculator();

            //asserts.
            sut.BaseChage(-1).ShouldBe(0);
            sut.BaseChage(80).ShouldBe(2.4);
            sut.BaseChage(145).ShouldBe(5.25);
            sut.BaseChage(245).ShouldBe(11.15);
        }
    }
}