using System;

namespace CompoundPatterns
{
    internal class RubberDuck : Quackable
    {
        internal override void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
