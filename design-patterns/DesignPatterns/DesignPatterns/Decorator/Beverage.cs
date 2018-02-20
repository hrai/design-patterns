using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public abstract class Beverage
    {
        public string Desc { get; }

        public abstract double GetCost();
    }
}
