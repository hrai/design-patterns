using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Factory;

namespace DesignPatterns.Factory
{
    public abstract class PizzaStore
    {
        protected AbsPizza _pizza;
        //private PizzaFactory _pizzaFactory;

        //public PizzaStore(PizzaFactory pizzaFactory)
        //{
        //    _pizzaFactory = pizzaFactory;
        //}

        public AbsPizza OrderPizza(string type)
        {
            _pizza = CreatePizza(type);

            _pizza.Prepare();
            _pizza.Bake();
            _pizza.Cut();
            _pizza.Box();

            return _pizza;
        }

        protected abstract AbsPizza CreatePizza(string type);
    }

    public class MelbournePizzaStore : PizzaStore
    {
        protected override AbsPizza CreatePizza(string type)
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

    public class SydneyPizzaStore : PizzaStore
    {
       protected  override AbsPizza CreatePizza(string type)
        {
            if (type == "Veggie")
            {
                _pizza = new SydneyVeggiePizza();
            }

            return _pizza;
        }
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

    public class Pizza : AbsPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing pizza...");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking pizza...");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pizza...");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing pizza...");
        }
    }

    public class SydneyVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Name = "syd veggie  Pizza";
            Console.WriteLine($"Preparing {Name}...");
        }
    }

    public class MelbVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Name = "Melb veggie Pizza";
            Console.WriteLine("Preparing Melb veggie pizza...");
        }
    }

    public class MelbPepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Name = "Melb pepperoni Pizza";
            Console.WriteLine($"Preparing {Name}...");
        }
    }
}
