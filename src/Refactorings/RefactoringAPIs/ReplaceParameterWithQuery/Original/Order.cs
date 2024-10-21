using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ReplaceParameterWithQuery.Original
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
            var discountLevel = 0;
            if(_quantity > 100)
            {
                discountLevel = 2;
            } else
            {
                discountLevel = 1;
            }

            return DiscountedPrice(basePrice, discountLevel);
        }

        private float DiscountedPrice(float basePrice, int discountLevel)
        {
            switch(discountLevel)
            {
                case 1: return basePrice * 0.95f;
                case 2: return basePrice * 0.9f;
                default: return basePrice;
            }
        }
    }
}
