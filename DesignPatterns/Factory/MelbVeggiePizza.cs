using System;
using DesignPatterns.Factory.AbstractIngredientFactory;

namespace DesignPatterns.Factory
{
    public class MelbVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Name = "Melb veggie Pizza";
            Console.WriteLine("Preparing Melb veggie pizza...");
        }

        public MelbVeggiePizza(IIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }
    }
}