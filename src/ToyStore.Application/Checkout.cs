using System;
using System.Xml;

namespace ToyStore.Application
{
    public class Checkout
    {
        public decimal TotalPrice { get; set; }
        private static readonly decimal discount = 0.9m;

        public void AddItem(decimal price, int quantity = 1)
        {
            TotalPrice += price * quantity;
            if (quantity >= 5)
                TotalPrice *= discount;
        }

        public void RemoveItem(decimal price)
        {
            TotalPrice = TotalPrice - price > 0 ? TotalPrice - price : 0;
        }
    }
}
