using System;
using DesignPatterns.Factory.AbstractIngredientFactory;

namespace DesignPatterns.Factory
{
    public class MelbPepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Name = "Melb pepperoni Pizza";
            Console.WriteLine($"Preparing {Name}...");
        }

        public MelbPepperoniPizza(IIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
        }
    }
}