namespace IntroducingSpecialCase.Refactored
{
    public class Clients
    {
        public string Client1(Site site)
        {
            var customer = site.Customer;
            var customerName = customer.Name;

            return customerName;
        }

        public Plan Client2(Site site)
        {
            var customer = site.Customer;
            var plan = customer.UtilityPlan;
            return plan;
        }
    }
}
