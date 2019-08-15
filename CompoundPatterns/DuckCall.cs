using System;

namespace CompoundPatterns
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}
