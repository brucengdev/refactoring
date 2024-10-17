namespace RemoveFlagArgument2.Refactored
{
    internal class DeliveryDateCalculator
    {
        /**
         * In this case, the method code is too complicated
         * that trying to refactor it is a bit more trouble than you would like
         * So we just add two more functions, and maybe try to hide the original function
         **/

        public DateTime RegularDeliveryDate(Order anOrder)
        {
            return DeliveryDate(anOrder, false);
        }

        public DateTime RushDeliveryDate(Order anOrder)
        {
            return DeliveryDate(anOrder, true);
        }

        private DateTime DeliveryDate(Order anOrder, bool isRush)
        {
            int deliveryTime;
            if (anOrder.DeliveryState == "MA" || anOrder.DeliveryState == "CT")
                deliveryTime = isRush ? 1 : 2;
            else if (anOrder.DeliveryState == "NY" || anOrder.DeliveryState == "NH")
            {
                deliveryTime = 2;
                if (anOrder.DeliveryState == "NH" && !isRush)
                {
                    deliveryTime = 3;
                }
            }
            else if (isRush)
            {
                deliveryTime = 3;
            }
            else if (anOrder.DeliveryState == "ME")
            {
                deliveryTime = 3;
            }
            else
            {
                deliveryTime = 4;
            }
            var result = anOrder.PlacedOn.AddDays(2 + deliveryTime);
            if (isRush)
            {
                result = result.AddDays(-1);
            }
            return result;
        }
    }
}
