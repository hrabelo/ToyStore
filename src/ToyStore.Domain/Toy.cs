namespace ToyStore.Domain
{
    public class Toy
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Toy(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            return (obj as Toy).Name == Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
