/**
 * Sometimes it looks like a field data belongs somewhere
 * So you need to move it there
 **/ 
namespace MoveField.Original
{
    public class Customer
    {
        private string _name;
        private float _discountRate;
        private CustomerContract _contract;
        public Customer(string name, float discountRate)
        {
            _name = name;
            _discountRate = discountRate;
            _contract = new CustomerContract(DateTime.Today);
        }

        public float DiscountRate
        {
            get
            {
                return _discountRate;
            }
        }

        public void BecomePreferred()
        {
            this._discountRate += 0.03f;
        }

        public float ApplyDiscount(float amount)
        {
            return amount - amount * DiscountRate;
        }
    }

    public class CustomerContract
    {
        private DateTime _startDate;
        public CustomerContract(DateTime startDate)
        {
            _startDate = startDate;
        }
    }
}
