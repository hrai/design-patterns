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

            var mallardDuck = new MallardDuck();
            var redheadDuck = new RedheadDuck();
            var duckCall = new DuckCall();
            var rubberDuck = new RubberDuck();

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
