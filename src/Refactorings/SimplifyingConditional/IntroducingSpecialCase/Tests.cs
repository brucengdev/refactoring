namespace IntroducingSpecialCase
{
    public class Tests
    {

        [Theory]
        [MemberData(nameof(Implementations))]
        public void TestClient1(object clientObject)
        {
            var client = clientObject as IClients;

            var customerName = client.Client1(new Site
            {
                Customer = null
            });
            Assert.Equal("occupant", customerName);

            customerName = client.Client1(new Site
            {
                Customer = new Customer
                {
                    Name = "BigCorp"
                }
            });

            Assert.Equal("BigCorp", customerName);
        }

        [Theory]
        [MemberData(nameof(Implementations))]
        public void TestClient2(object clientObject)
        {
            var client = clientObject as IClients;

            var plan = client.Client2(new Site
            {
                Customer = null
            });
            Assert.Equal(Plan.Basic, plan);

            plan = client.Client2(new Site
            {
                Customer = new Customer
                {
                    Name = "BigCorp",
                    UtilityPlan = Plan.Premium
                }
            });

            Assert.Equal(Plan.Premium, plan);
        }

        public static IEnumerable<object[]> Implementations = new[]
        {
            new object[] { new Original() },
            new object[] { new Refactored() }
        };
    }
}