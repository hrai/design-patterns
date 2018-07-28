using System;

namespace DesignPatterns.Factory
{
    public class MelbVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Name = "Melb veggie Pizza";
            Console.WriteLine("Preparing Melb veggie pizza...");
        }
    }
}