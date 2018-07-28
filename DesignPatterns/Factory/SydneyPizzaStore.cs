namespace DesignPatterns.Factory
{
    public class SydneyPizzaStore : PizzaStore
    {
        protected  override AbstractPizza CreatePizza(string type)
        {
            if (type == "Veggie")
            {
                _pizza = new SydneyVeggiePizza();
            }

            return _pizza;
        }
    }
}