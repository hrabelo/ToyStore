using ToyStore.Application;
using Xunit;

namespace ToyStore.UnitTest
{
    public class CheckoutTest
    {
        [Fact]
        public void AddItem_Should_Increase_Total_Chart_Price()
        {
            var checkout = new Checkout();
            checkout.AddItem(5);
            Assert.Equal(5, checkout.TotalPrice);
        }

        [Fact]
        public void AddItem_5_Times_Same_Product_Should_Give_10_Percent_Discount()
        {
            var checkout = new Checkout();
            checkout.AddItem(5, 10);
            Assert.Equal(45, checkout.TotalPrice);
        }
    }
}
