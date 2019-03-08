using System;

namespace DesignPatterns.Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var melbPizzaStore = new MelbournePizzaStore();
            var sydPizzaStore = new SydneyPizzaStore();

            var melbPizza = melbPizzaStore.OrderPizza("Pepperoni");
            var sydPizza = sydPizzaStore.OrderPizza("Veggie");

            Console.WriteLine($"Melb pizza ordered was {melbPizza.Name}");
            Console.WriteLine($"Syd pizza ordered was {sydPizza.Name}");
            Console.ReadKey();
        }
    }
}
