using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompoundPatterns
{
    class Flock : IQuackable

    {
        private IList<IQuackable> _quackers;

        public Flock(IList<IQuackable> quackers)
        {
            _quackers = quackers;
        }

        public void Quack()
        {
            _quackers.ToList().ForEach(quacker => quacker.Quack());
        }
    }
}
