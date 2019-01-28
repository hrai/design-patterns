using System;

namespace State
{
    public class HasQuarter: IState
    {
        private IMachine _machine;

        public HasQuarter(IMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter already inserted");
        }

        public void EjectQuarter()
        {
            _machine.SetState(_machine.GetNoQuarter());
            Console.WriteLine("quarter ejected");
        }

        public void TurnCrank()
        {
            _machine.SetState(_machine.GetGumballSold());
            Console.WriteLine("gumball sold");

            DispenseGumball();
        }

        public void DispenseGumball()
        {
            Console.WriteLine("Rolling gumball out of machine");

            if(_machine.Gumballs() > 0)
                _machine.SetState(_machine.GetNoQuarter());

            _machine.SetState(_machine.GetOutOfGumballs());
        }
    }
}
