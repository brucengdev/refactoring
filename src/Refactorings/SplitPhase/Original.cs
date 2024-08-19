namespace SplitPhase.Original
{
    public class PriceCalculator
    {
        private static Dictionary<string, float> _productPrices = new()
        {
            ["Cup"] = 2.5f 
        };
        public static float CalculateOrderPrice(string orderString)
        {
            /**
             * This operation is doing two things
             * First parse the order string
             * Then calculate the order price
             * 
             * It can be valuable to split this into two phases.
             **/
            var orderData = orderString.Split("-");
            var productPrice = _productPrices[orderData[0]];
            var orderPrice = Convert.ToInt32(orderData[1]) * productPrice;
            return orderPrice;
        }

        public static void Main()
        {
            Console.WriteLine("Price = {0}", CalculateOrderPrice("Cup-25"));
        }
    }
}
