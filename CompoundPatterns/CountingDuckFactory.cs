namespace CompoundPatterns
{
    internal class CountingDuckFactory : AbstractDuckFactory
    {
        internal override IQuackable CreateMallardDuck()
        {
            var mallardDuck = new QuackCounter(new MallardDuck());
            return mallardDuck;
        }

        internal override IQuackable CreateRedheadDuck()
        {
            var redheadDuck = new QuackCounter(new RedheadDuck());
            return redheadDuck;
        }

        internal override IQuackable CreateDuckCall()
        {
            var duckCall = new QuackCounter(new DuckCall());
            return duckCall;
        }

        internal override IQuackable CreateRubberDuck()
        {
            var rubberDuck = new QuackCounter(new RubberDuck());
            return rubberDuck;
        }
    }
}
