using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Decaf : Beverage
    {
        public string Desc => $"base.Desc {typeof(Decaf)}";

        public override double GetCost()
        {
            return 1.05;
        }
    }
}
