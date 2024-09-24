namespace ChangeValueToReference.Refactored
{
    public class Customer
    {
        private int _id { get; }
        public Customer(int id) { _id = id; }
    }

    public class  Order
    {
        private Customer _customer { get; set; }
        private string _number { get; set; }
        public Order(string number, int customerId)
        {
            _customer = new Customer(customerId);
            _number = number;
        }
    }
}
