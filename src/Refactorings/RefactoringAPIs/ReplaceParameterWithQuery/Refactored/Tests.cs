using Shouldly;

namespace ReplaceParameterWithQuery.Refactored
{
    public class Tests
    {
        [Fact]
        public void OrderPriceTest()
        {
            //asserts

            (new Order(90, 20)).GetFinalPrice().ShouldBe(90 * 20 * 0.95f);
            (new Order(120, 5)).GetFinalPrice().ShouldBe(120 * 5 * 0.9f);
        }
    }
}