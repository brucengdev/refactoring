namespace IntroducingSpecialCase.Refactored
{
    public class Site
    {
        private Customer _customer = null;
        public Customer Customer { 
            get{
                if(_customer == null)
                {
                    return new UnknownCustomer();
                }
                return _customer;
            }
            set{
                _customer = value; 
            }
        }
    }
}
