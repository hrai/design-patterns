using DesignPatterns.Factory.AbstractIngredientFactory;

namespace DesignPatterns.Factory
{
    public class SydneyPizzaStore : PizzaStore
    {
        protected override AbstractPizza CreatePizza(string type)
        {
            var factory = new SydIngredientFactory();

            if (type == "Veggie")
            {
                _pizza = new SydneyVeggiePizza(factory);
            }

            return _pizza;
        }
    }
}