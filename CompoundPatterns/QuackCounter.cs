using System;

namespace CompoundPatterns
{
    internal class QuackCounter : Quackable
    {
        private readonly Quackable _duck;
        private static int _totalQuacks;

        public QuackCounter(Quackable duck)
        {
            _duck = duck;
            _totalQuacks = 0;
        }

        internal override void Quack()
        {
            _duck.Quack();
            _totalQuacks++;

            OnSomethingHappened(this, EventArgs.Empty);
        }

        public static int GetQuacks()
        {
            return _totalQuacks;
        }
    }
}
