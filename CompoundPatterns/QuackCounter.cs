namespace CompoundPatterns
{
    internal class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;
        private static int _totalQuacks;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            _totalQuacks = 0;
        }

        public void Quack()
        {
            _duck.Quack();
            _totalQuacks++;
        }

        public static int GetQuacks()
        {
            return _totalQuacks;
        }
    }
}
