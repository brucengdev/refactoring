namespace ChangeValueToReference.Original
{

    public class CustomerRepository
    {
        private Dictionary<int, Customer> _customers = new();

        public Customer RegisterCustomer(int customerId)
        {
            var customer = FindCustomer(customerId);
            if(customer != null) {  return customer; }

            customer = new Customer(customerId);
            _customers[customerId] = customer;
            return customer;
        }

        public Customer? FindCustomer(int customerId)
        {
            if (_customers.TryGetValue(customerId, out Customer? customer))
            {
                return customer;
            }
            return null;
        }
    }
    public class Customer
    {
        private int _id { get; }
        public Customer(int id) { _id = id; }
    }

    public class  Order
    {
        private Customer _customer { get; set; }
        private string _number { get; set; }
        public Order(string number, int customerId, CustomerRepository customerRepo)
        {
            _customer = customerRepo.RegisterCustomer(customerId);
            _number = number;
        }
    }
}
