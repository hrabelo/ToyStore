using System.Collections.Generic;
using System.Linq;
using ToyStore.Domain;

namespace ToyStore.Application
{
    public class Checkout
    {
        private const decimal discount = 0.9m;
        private Dictionary<Toy, int> _chart;

        public decimal TotalPrice
        {
            get { return _chart.Sum(o => o.Value * GetDiscount(o.Value) * o.Key.Price); }
        }
                
        public Checkout()
        {
            _chart = new Dictionary<Toy, int>();
        }

        public void AddItem(Toy toy, int quantity = 1)
        {
            if (!_chart.ContainsKey(toy))
                _chart.Add(toy, quantity);
            else
                _chart[toy] += quantity;
        }

        public void RemoveItem(Toy toy, int quantity = 1)
        {
            if (_chart.ContainsKey(toy))
            {
                if (quantity >= _chart[toy])
                    _chart.Remove(toy);
                else
                    _chart[toy] -= quantity;
            }
        }

        private decimal GetDiscount(int quantity)
        {
            if (quantity >= 5)
                return discount;

            return 1;
        }
    }
}
