using DesignPatterns.Factory.AbstractIngredientFactory;

namespace DesignPatterns.Factory
{
    public class MelbournePizzaStore : PizzaStore
    {
        protected override AbstractPizza CreatePizza(string type)
        {
            var factory = new MelbIngredientFactory();

            if (type == "Pepperoni")
            {
                _pizza = new MelbPepperoniPizza(factory);
            }
            else if (type == "Veggie")
            {
                _pizza = new MelbVeggiePizza(factory);
            }

            return _pizza;
        }
    }
}