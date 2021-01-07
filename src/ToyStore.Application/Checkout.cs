namespace ToyStore.Application
{
    public class Checkout
    {
        public decimal TotalPrice { get; set; }

        public void AddItem(decimal price, int quantity = 1)
        {
            if (quantity >= 5)
                TotalPrice += price * quantity * 0.9m;
            else
                TotalPrice += price*quantity;
        }
    }
}
