namespace RemoveFlagArgument.Refactored
{
    internal class Client
    {
        private readonly DeliveryDateCalculator _deliveryDateCal;
        private readonly IEmailSender _emailSender;
        public Client(DeliveryDateCalculator deliveryDateCal, IEmailSender emailSender)
        {
            _deliveryDateCal = deliveryDateCal;
            _emailSender = emailSender;
        }

        public void PlaceOrders(List<Order> orders)
        {
            var title = "Orders placed!";
            var orderLines = orders
                .Select(order =>
                {
                    var deliveryDate = _deliveryDateCal.DeliveryDate(order, false);
                    return $"{order.Name} (placed on {order.PlacedOn}), delivery by {deliveryDate}";
                });
            var content = string.Join('\n', orderLines);
            _emailSender.SendEmail(title, content);
        }

        public void PlaceRushOrders(List<Order> orders)
        {
            var title = "Orders with express delivery placed!";
            var orderLines = orders
                .Select(order =>
                {
                    var deliveryDate = _deliveryDateCal.DeliveryDate(order, true);
                    return $"{order.Name} (placed on {order.PlacedOn}), delivery by {deliveryDate}";
                });
            var content = string.Join('\n', orderLines);
            _emailSender.SendEmail(title, content);
        }
    }
}
