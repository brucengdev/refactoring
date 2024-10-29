using Shouldly;

namespace PullUpMethod.Original
{
    public class Tests
    {
        [Fact]
        public void TestCreateEmployee()
        {
            var employee = new Employee("Tom", 123, 225);

            employee.Name.ShouldBe("Tom");
            employee.Id.ShouldBe(123);
            employee.MonthlyCost.ShouldBe(225);
        }
    }
}