namespace ReplaceTempWithQuery.Original
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
            this._quantity = quantity;
            this._item = item;
        }

        public float GetPrice()
        {
            var basePrice = _quantity * _item.Price;
            var discountFactor = 0.98;
            if(basePrice > 1000)
            {
                discountFactor -= 0.03;
            }
            return (float)(basePrice * discountFactor);
        }
    }
}
