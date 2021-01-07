using Xunit;

namespace ToyStore.UnitTest
{
    public class CheckoutTest
    {
        [Fact]
        public void AddItem_Should_Increase_Total_Chart_Price()
        {
            var checkout = new Checkout();
            checkout.AddItem(new Toy(5));
            Assert.Equal(5, checkout.TotalPrice);
        }
    }
}
