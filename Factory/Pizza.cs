using System;
using DesignPatterns.Factory.AbstractIngredientFactory;

namespace DesignPatterns.Factory
{
    public class Pizza : AbstractPizza
    {
        public IDough Dough;
        public ISauce Sauce;
        public IMeat Meat;
        public IVeggie Veggie;

        public Pizza(IIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Meat = IngredientFactory.CreateMeat();
            Veggie = IngredientFactory.CreateVeggie();
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing pizza...");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking pizza...");
            Console.WriteLine(Dough.Name());
            Console.WriteLine(Sauce.Name());
            Console.WriteLine(Meat.Name());
            Console.WriteLine(Veggie.Name());
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
}