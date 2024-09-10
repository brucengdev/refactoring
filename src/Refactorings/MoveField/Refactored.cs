/**
 * Sometimes it looks like a field data belongs somewhere
 * So you need to move it there
 **/ 
namespace MoveField.Reactored
{
    public class Customer
    {
        private string _name;
        private CustomerContract _contract;
        public Customer(string name, float discountRate)
        {
            _name = name;
            _contract = new CustomerContract(DateTime.Today, discountRate);
        }

        public float DiscountRate
        {
            get
            {
                return _contract.DiscountRate;
            }
            set
            {
                _contract.DiscountRate = value;
            }
        }

        public void BecomePreferred()
        {
            DiscountRate += 0.03f;
        }

        public float ApplyDiscount(float amount)
        {
            return amount - amount * DiscountRate;
        }
    }

    public class CustomerContract
    {
        private DateTime _startDate;
        private float _discountRate;
        public CustomerContract(DateTime startDate, float discountRate)
        {
            _startDate = startDate;
            _discountRate = discountRate;
        }

        public float DiscountRate
        {
            get
            {
                return _discountRate;
            }
            set
            {
                _discountRate = value;
            }
        }
    }
}
