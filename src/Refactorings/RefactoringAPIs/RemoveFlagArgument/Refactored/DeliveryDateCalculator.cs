namespace RemoveFlagArgument.Refactored
{
    internal class DeliveryDateCalculator
    {
        public DateTime DeliveryDate(Order anOrder, bool isRush)
        {
            if(isRush)
            {
                int deliveryTime;
                if((new []{ "MA", "CT" }).Contains(anOrder.DeliveryState)) {
                    deliveryTime = 1;
                }
                else if ((new[] { "NY", "NH" }).Contains(anOrder.DeliveryState))
                {
                    deliveryTime = 2;
                }else
                {
                    deliveryTime = 3;
                }

                return anOrder.PlacedOn.AddDays(1 + deliveryTime);
            }else
            {
                int deliveryTime;
                if ((new[] { "MA", "CT", "NY" }).Contains(anOrder.DeliveryState))
                {
                    deliveryTime = 2;
                } else if ((new[] { "ME", "NH" }).Contains(anOrder.DeliveryState))
                {
                    deliveryTime = 3;
                } else
                {
                    deliveryTime = 4;
                }
                return anOrder.PlacedOn.AddDays(2 + deliveryTime);
            }
        }
    }
}
