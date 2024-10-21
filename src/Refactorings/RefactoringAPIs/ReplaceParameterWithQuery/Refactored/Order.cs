using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ReplaceParameterWithQuery.Refactored
{
    internal class Order
    {
        private int _quantity { get; set; }
        private float _itemPrice { get; set; }

        public Order(int quantity, float itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public float GetFinalPrice()
        {
            var basePrice = _quantity * _itemPrice;

            return DiscountedPrice(basePrice);
        }

        private int DiscountLevel
        {
            get
            {
                return _quantity > 100? 2: 1;
            }
        }

        private float DiscountedPrice(float basePrice)
        {
            switch(DiscountLevel)
            {
                case 1: return basePrice * 0.95f;
                case 2: return basePrice * 0.9f;
                default: return basePrice;
            }
        }
    }
}
