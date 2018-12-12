using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Espresso: Beverage
    {
        public string Desc => $"{base.Desc} {typeof(Espresso)}";

        public override double GetCost()
        {
            return 1.99;
        }
    }
}
