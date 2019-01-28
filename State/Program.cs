using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var gumballMachine = new GumballMachine(10);
            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();


            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
        }
    }
}
