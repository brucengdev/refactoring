namespace IntroducingSpecialCase.Original
{
    public class Clients
    {
        public string Client1(Site site)
        {
            var customer = site.Customer;
            var customerName = "";
            if(customer == null)
            {
                customerName = "occupant";
            }else
            {
                customerName = customer.Name;
            }

            return customerName;
        }

        public Plan Client2(Site site)
        {
            var customer = site.Customer;
            var plan = customer == null? Plan.Basic: customer.UtilityPlan;
            return plan;
        }
    }
}
