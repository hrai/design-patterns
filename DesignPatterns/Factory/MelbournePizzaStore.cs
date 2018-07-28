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

    public class MelbIngredientFactory:IIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickDough();
        }

        public ISauce CreateSauce()
        {
            return new BbqSauce();
        }

        public IMeat CreateMeat()
        {
            return new PorkMeat();
        }

        public IVeggie CreateVeggie()
        {
            return new Capsicum();
        }
    }

    public class ThickDough : IDough
    {
        public string Name() { return this.GetType().FullName; }
    }

    public class BbqSauce : ISauce
    {
        public string Name() { return this.GetType().FullName; }
    }

    public class PorkMeat : IMeat
    {
        public string Name() { return this.GetType().FullName; }
    }

    public class Capsicum : IVeggie
    {
        public string Name() { return this.GetType().FullName; }
    }
}