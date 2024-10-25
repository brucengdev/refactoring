using Shouldly;

namespace PullUpMethod.Original
{
    public class Tests
    {
        [Fact]
        public void TestCost()
        {
            var employee = new Employee()
            {
                MonthlyCost = 22
            };
            var department = new Department() {
                MonthlyCost = 23
            };

            var sut = new CostCalculator();
            
            sut.GetAnnualCost(employee).ShouldBe(22 * 12);
            sut.GetAnnualCost(department).ShouldBe(23 * 12);
        }
    }
}