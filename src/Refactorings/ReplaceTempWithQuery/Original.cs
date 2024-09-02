namespace ReplaceTempWithQuery.Refactored
{
    public class Item
    {
        public float Price { get;set; }
    }
    public class Order
    {
        private int _quantity;
        private Item _item;
        public Order(int quantity, Item item)
        {
            _quantity = quantity;
            _item = item;
        }

        private double _basePrice
        {
            get
            {
                return _quantity * _item.Price;
            }
        }

        private double _discountFactor
        {
            get
            {
                var value = 0.98;
                if(_basePrice > 1000)
                {
                    value -= 0.03;
                }
                return value;
            }
        }

        public float GetPrice()
        {
            return (float)(_basePrice * _discountFactor);
        }
    }
}
