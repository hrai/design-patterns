using System;

namespace CompoundPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var sim = new DuckSimulator();
            sim.Simulate();

            Console.ReadKey();
        }
    }

    internal class DuckSimulator
    {
        internal void Simulate()
        {
            Console.WriteLine("Simulating quacking...");

            var mallardDuck = new QuackCounter(new MallardDuck());
            var redheadDuck = new QuackCounter(new RedheadDuck());
            var duckCall = new QuackCounter(new DuckCall());
            var rubberDuck = new QuackCounter(new RubberDuck());
            var gooseDuck = new QuackCounter(new GooseAdapter(new Goose()));

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            var quacks = QuackCounter.GetQuacks();
            Console.WriteLine($"Total quacks = {quacks}");
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
