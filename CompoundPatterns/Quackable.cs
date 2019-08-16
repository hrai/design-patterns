using System;

namespace CompoundPatterns
{
    internal abstract class Quackable
    {
        public event EventHandler SomethingHappened;

        protected virtual void OnSomethingHappened(object sender, EventArgs args)
        {
            var handler = SomethingHappened;
            handler?.Invoke(this, EventArgs.Empty);
        }

        internal abstract void Quack();
    }
}
