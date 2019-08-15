using System;

namespace CompoundPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CountingDuckFactory();
            var sim = new DuckSimulator(factory);

            sim.Simulate();

            Console.ReadKey();
        }
    }

    internal class DuckSimulator
    {
        private readonly CountingDuckFactory _countingDuckFactory;

        public DuckSimulator(CountingDuckFactory countingDuckFactory)
        {
            _countingDuckFactory = countingDuckFactory;
        }

        internal void Simulate()
        {
            Console.WriteLine("Simulating quacking...");

            var gooseDuck = new GooseAdapter(new Goose());

            Simulate(_countingDuckFactory.CreateMallardDuck());
            Simulate(_countingDuckFactory.CreateRedheadDuck());
            Simulate(_countingDuckFactory.CreateDuckCall());
            Simulate(_countingDuckFactory.CreateRubberDuck());
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
