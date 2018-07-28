using System;
using DesignPatterns.Factory.AbstractIngredientFactory;

namespace DesignPatterns.Factory
{
    public class SydneyVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Name = "syd veggie  Pizza";
            Console.WriteLine($"Preparing {Name}...");
        }

        public SydneyVeggiePizza(IIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }
    }
}