using System;

namespace CompoundPatterns
{
    internal class DuckCall : Quackable
    {
        internal override void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}
