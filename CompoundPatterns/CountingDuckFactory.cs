namespace CompoundPatterns
{
    internal class CountingDuckFactory : AbstractDuckFactory
    {
        internal override Quackable CreateMallardDuck()
        {
            var mallardDuck = new QuackCounter(new MallardDuck());
            return mallardDuck;
        }

        internal override Quackable CreateRedheadDuck()
        {
            var redheadDuck = new QuackCounter(new RedheadDuck());
            return redheadDuck;
        }

        internal override Quackable CreateDuckCall()
        {
            var duckCall = new QuackCounter(new DuckCall());
            return duckCall;
        }

        internal override Quackable CreateRubberDuck()
        {
            var rubberDuck = new QuackCounter(new RubberDuck());
            return rubberDuck;
        }
    }
}
