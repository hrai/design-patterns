using System;

namespace DesignPatterns.Factory
{
    public class Pizza : AbstractPizza
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
}