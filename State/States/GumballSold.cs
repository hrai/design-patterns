﻿using System;

namespace State
{
    public class GumballSold: IState
    {
        private IMachine _machine;

        public GumballSold(IMachine machine)
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
            Console.WriteLine("Dispensing gumball...");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Not getting another gumball; Currently dispensing gumball...");
        }

        public void DispenseGumball()
        {
            Console.WriteLine("Dispensing gumball...");
        }
    }
}
