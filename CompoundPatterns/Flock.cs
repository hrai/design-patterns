using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompoundPatterns
{
    class Flock : Quackable

    {
        private readonly IList<Quackable> _quackers;

        public Flock(IList<Quackable> quackers)
        {
            _quackers = quackers;
        }

        internal override void Quack()
        {
            _quackers.ToList().ForEach(quacker => quacker.Quack());
        }
    }
}
