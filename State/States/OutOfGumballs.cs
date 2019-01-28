using System;

namespace State
{
    public class OutOfGumballs : IState
    {
        private IMachine _machine;

        public OutOfGumballs (IMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Out of gumballs");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Out of gumballs");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Out of gumballs");
        }

        public void DispenseGumball()
        {
            Console.WriteLine("Out of gumballs");
        }
    }
}
