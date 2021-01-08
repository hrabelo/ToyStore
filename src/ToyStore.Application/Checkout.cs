using System.Collections.Generic;

namespace ToyStore.Application
{
    public class Checkout
    {
        public decimal TotalPrice { get; set; }
        private readonly decimal discount = 0.9m;
        private bool hasDiscount = false;

        public void AddItem(decimal price, int quantity = 1)
        {
            TotalPrice += price * quantity;
            if (quantity >= 5)
            {
                TotalPrice *= discount;
                hasDiscount = true;
            }

        }

        public void RemoveItem(decimal price, int quantity = 1)
        {
            if (hasDiscount)
            {
                TotalPrice /= discount;
                hasDiscount = false;
            }
            TotalPrice = TotalPrice - quantity * price > 0 ? TotalPrice - quantity * price : 0;
        }
    }
}
