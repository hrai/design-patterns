using System;

namespace CompoundPatterns
{
    internal abstract class Quackable
    {
        public event EventHandler SomethingHappened;

        protected virtual void OnQuacked(object sender, EventArgs args)
        {
            var handler = SomethingHappened;
            handler?.Invoke(sender, EventArgs.Empty);
        }

        internal abstract void Quack();
    }
}
