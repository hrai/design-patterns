using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public string Desc => $"{base.Desc} {nameof(Mocha)}";

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double GetCost()
        {
            return .2 + _beverage.GetCost();
        }
    }
}
