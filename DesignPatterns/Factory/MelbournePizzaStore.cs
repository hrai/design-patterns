namespace DesignPatterns.Factory
{
    public class MelbournePizzaStore : PizzaStore
    {
        protected override AbstractPizza CreatePizza(string type)
        {
            if (type == "Pepperoni")
            {
                _pizza = new MelbPepperoniPizza();
            }
            else if (type == "Veggie")
            {
                _pizza = new MelbVeggiePizza();
            }

            return _pizza;
        }
    }
}