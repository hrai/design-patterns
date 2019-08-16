using System;

namespace CompoundPatterns
{
    internal class Quackologist
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine($"{(sender as Quackable)?.GetType().Name}'s Quack was invoked.");
        }
    }
}
