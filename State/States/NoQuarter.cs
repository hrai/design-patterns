using System;

namespace State
{
    public class NoQuarter: IState
    {
        private IMachine _machine;

        public NoQuarter(IMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            _machine.SetState(_machine.GetHasQuarter());
            Console.WriteLine("Quarter inserted");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("No quarter inserted");
        }

        public void TurnCrank()
        {
            Console.WriteLine("no quarter");
        }

        public void DispenseGumball()
        {
            Console.WriteLine("no quarter");
        }
    }
}
