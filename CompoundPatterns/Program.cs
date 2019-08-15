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
            var gooseDuck = new GooseAdapter(new Goose());

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
