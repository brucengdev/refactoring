namespace SplitPhase.Refactored
{

    internal class OrderData
    {
        public string ProductName;
        public int OrderQuantity;
    }
    public class PriceCalculator
    {
        private static Dictionary<string, float> _productPrices = new()
        {
            ["Cup"] = 2.5f 
        };
        public static float CalculateOrderPrice(string orderString)
        {
            /**
             * Calculating order price is splitted into two phases
             * Using OrderData intermediate data structure to join two phases.
             * The second phase should only use function parameters that are specific to the
             * second phase (not shown in this example).
             **/
            var orderData = ParseOrder(orderString);
            var orderPrice = CalculateProductPrice(orderData);
            return orderPrice;
        }

        private static float CalculateProductPrice(OrderData orderData)
        {
            var productPrice = _productPrices[orderData.ProductName];
            var orderPrice = orderData.OrderQuantity * productPrice;
            return orderPrice;
        }

        private static OrderData ParseOrder(string orderString)
        {
            var parsed = orderString.Split("-");
            var orderData = new OrderData();
            orderData.ProductName = parsed[0];
            orderData.OrderQuantity = Convert.ToInt32(parsed[1]);
            return orderData;
        }

        public static void Main()
        {
            Console.WriteLine("Price = {0}", CalculateOrderPrice("Cup-25"));
        }
    }
}
