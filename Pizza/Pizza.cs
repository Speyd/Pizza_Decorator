using Component;

namespace PizzaInfo
{
    public class Pizza : IComponent
    {
        public int Price { get; set; }

        private readonly PizzaTipe pizzaTipe;

        public Pizza(PizzaTipe pizzaTipe, int price)
        {
            this.pizzaTipe = pizzaTipe;
            Price = price;
        }

        public void addTopping(int price)
        {
            Price += price;
        }
        public void show()
        {
            Console.WriteLine($"Pizza({pizzaTipe.ToString()})\nToping Pizza:");
        }
    }
}
