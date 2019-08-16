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

            IList<Quackable> quackers = new List<Quackable>();
            var mallardDuck = _countingDuckFactory.CreateMallardDuck();
            quackers.Add(mallardDuck);
            quackers.Add(_countingDuckFactory.CreateRedheadDuck());
            quackers.Add(_countingDuckFactory.CreateDuckCall());
            quackers.Add(_countingDuckFactory.CreateRubberDuck());
            quackers.Add(gooseDuck);

            AttachEventHandlers(mallardDuck);

            var flock = new Flock(quackers);
            Simulate(flock);

            var quacks = QuackCounter.GetQuacks();
            Console.WriteLine($"Total quacks = {quacks}");
        }

        private static void AttachEventHandlers(Quackable mallardDuck)
        {
            var quackologist = new Quackologist();
            mallardDuck.SomethingHappened += quackologist.HandleEvent;
        }

        private void Simulate(Quackable quackable)
        {
            quackable.Quack();
        }
    }
}
