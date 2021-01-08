using ToyStore.Application;
using ToyStore.Domain;
using Xunit;

namespace ToyStore.UnitTest
{
    public class CheckoutTest
    {
        [Fact]
        public void AddItem_Should_Increase_Total_Chart_Price()
        {
            var checkout = new Checkout();
            checkout.AddItem(new Toy("Toy1", 5));
            Assert.Equal(5, checkout.TotalPrice);
        }

        [Fact]
        public void AddItem_5_Times_Same_Product_Should_Give_10_Percent_Discount()
        {
            var checkout = new Checkout();
            checkout.AddItem(new Toy("Toy1", 5), 4);
            checkout.AddItem(new Toy("Toy1", 5), 6);
            checkout.AddItem(new Toy("Toy2", 20), 1);
            
            Assert.Equal(65m, checkout.TotalPrice);
        }

        [Fact]
        public void RemoveItem_Should_Decrease_Total_Chart_Price()
        {
            var checkout = new Checkout();
            checkout.AddItem(new Toy("Toy1", 10));
            checkout.AddItem(new Toy("Toy2", 5), 3);
            checkout.RemoveItem(new Toy("Toy2", 5));
            Assert.Equal(20m, checkout.TotalPrice);
        }

        [Fact]
        public void RemoveItem_Should_Never_Make_Total_Chart_Price_Below_Zero()
        {
            var checkout = new Checkout();
            checkout.AddItem(new Toy("Toy1", 10));
            checkout.RemoveItem(new Toy("Toy1", 30));
            checkout.RemoveItem(new Toy("Toy2", 30));
            Assert.True(checkout.TotalPrice >= 0);
        }


        [Fact]
        public void RemoveItem_Below_Discount_Mark_Should_Remove_Discount()
        {
            var checkout = new Checkout();
            checkout.AddItem(new Toy("Toy1", 10), 6);
            checkout.RemoveItem(new Toy("Toy1", 10), 2);
            Assert.Equal(40m, checkout.TotalPrice);
        }
    }
}
