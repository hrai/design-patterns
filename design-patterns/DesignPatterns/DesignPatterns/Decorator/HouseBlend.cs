using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class HouseBlend : Beverage
    {
        public string Desc => $"{base.Desc} {typeof(HouseBlend)}";

        public override double GetCost()
        {
            return .89;
        }
    }
}
