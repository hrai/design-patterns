using System.Collections.Generic;
using System.Text;
using DesignPatterns.Factory;

namespace DesignPatterns.Factory
{
    public abstract class PizzaStore
    {
        protected AbstractPizza _pizza;
        //private PizzaFactory _pizzaFactory;

        //public PizzaStore(PizzaFactory pizzaFactory)
        //{
        //    _pizzaFactory = pizzaFactory;
        //}

        public AbstractPizza OrderPizza(string type)
        {
            _pizza = CreatePizza(type);

            _pizza.Prepare();
            _pizza.Bake();
            _pizza.Cut();
            _pizza.Box();

            return _pizza;
        }

        // Factory method that will be overridden by the subclass to provide
        // individual implementations
        protected abstract AbstractPizza CreatePizza(string type);
    }

    //public class PizzaFactory
    //{
    //    private Pizza _pizza;

    //    public Pizza CreatePizza(string type)
    //    {
    //        if (type == "Veggie")
    //        {
    //            _pizza = new VeggiePizza();
    //        }

    //        return _pizza;
    //    }
    //}
}
