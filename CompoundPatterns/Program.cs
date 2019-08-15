using System;
using System.Collections.Generic;

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

            IList<IQuackable> quackers = new List<IQuackable>();
            quackers.Add(_countingDuckFactory.CreateMallardDuck());
            quackers.Add(_countingDuckFactory.CreateRedheadDuck());
            quackers.Add(_countingDuckFactory.CreateDuckCall());
            quackers.Add(_countingDuckFactory.CreateRubberDuck());
            quackers.Add(gooseDuck);

            var flock = new Flock(quackers);
            Simulate(flock);

            var quacks = QuackCounter.GetQuacks();
            Console.WriteLine($"Total quacks = {quacks}");
        }

        private void Simulate(IQuackable quackable)
        {
            quackable.Quack();
        }
    }
}
