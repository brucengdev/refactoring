namespace ReplaceCommandWithFunction.Refactored
{
    internal class Program
    {
        public static void main(string[] args)
        {
            var customer = new Customer();
            var usage = 250;
            var provider = new Provider();

            var monthCharge = Charge(customer, usage, provider);
        }

        public static float Charge(Customer customer, int usage, Provider provider)
        {
            var baseCharge = customer.BaseRate * usage;
            return baseCharge + provider.ConnectionCharge;
        }
    }
}
