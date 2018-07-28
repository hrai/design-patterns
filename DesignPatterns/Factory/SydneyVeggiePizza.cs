using System;

namespace DesignPatterns.Factory
{
    public class SydneyVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Name = "syd veggie  Pizza";
            Console.WriteLine($"Preparing {Name}...");
        }
    }
}