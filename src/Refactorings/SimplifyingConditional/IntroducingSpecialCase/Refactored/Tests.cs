namespace IntroducingSpecialCase.Refactored
{
    public class Tests
    {

        [Fact]
        public void TestClient1()
        {
            var clients = new Clients();
            var customerName = clients.Client1(new Site
            {
                Customer = null
            });
            Assert.Equal("occupant", customerName);

            customerName = clients.Client1(new Site
            {
                Customer = new Customer
                {
                    Name = "BigCorp"
                }
            });

            Assert.Equal("BigCorp", customerName);
        }

        [Fact]
        public void TestClient2()
        {
            var clients = new Clients();
            var plan = clients.Client2(new Site
            {
                Customer = null
            });
            Assert.Equal(Plan.Basic, plan);

            plan = clients.Client2(new Site
            {
                Customer = new Customer
                {
                    Name = "BigCorp",
                    UtilityPlan = Plan.Premium
                }
            });

            Assert.Equal(Plan.Premium, plan);
        }
    }
}