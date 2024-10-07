namespace IntroducingSpecialCase.Original
{
    internal class Original
    {
        public void Client1(Site site)
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
        }
    }
}
