namespace ToyStore.Application
{
    public class Checkout
    {
        public decimal TotalPrice { get; set; }

        public void AddItem(decimal price)
        {
            TotalPrice += price;
        }
    }
}
