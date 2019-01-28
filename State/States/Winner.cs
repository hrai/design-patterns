using System;

namespace State
{
    public class Winner: IState
    {
        private IMachine _machine;

        public Winner(IMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter already inserted");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Cannot Eject Quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Not getting another gumball; Currently dispensing gumball...");
        }

        public void DispenseGumball()
        {
            if(_machine.Gumballs() == 2)
            {
                Console.WriteLine("Rolling 2 gumballs out of machine");

                _machine.ResetBall();
                _machine.ResetBall();

                _machine.SetState(_machine.GetOutOfGumballs());
            }
            else if(_machine.Gumballs() ==1)
            {
                Console.WriteLine("Rolling 1 gumball out of machine");
                _machine.ResetBall();
                _machine.SetState(_machine.GetOutOfGumballs());
            }
            else
            {
                Console.WriteLine("Rolling 2 gumballs out of machine");

                _machine.ResetBall();
                _machine.ResetBall();

                _machine.SetState(_machine.GetNoQuarter());
            }
        }
    }
}
