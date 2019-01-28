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
            if(IsWinner())
            {
                Console.WriteLine("Congrats you're the winner");
                _machine.SetState(_machine.GetWinner());
            }
            else
            {
                Console.WriteLine("gumball sold");
                _machine.SetState(_machine.GetGumballSold());
            }
        }

        public void DispenseGumball()
        {
            Console.WriteLine("Dispensing not allowed");
        }

        private bool IsWinner()
        {
            var random = new Random();
            var chance = random.Next(1, 10);

            return chance == 1;
        }
    }
}
