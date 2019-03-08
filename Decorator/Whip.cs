using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public override string Desc => $"{base.Desc} {nameof(Whip)}";

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double GetCost()
        {
            return .6 + _beverage.GetCost();
        }
    }
}
