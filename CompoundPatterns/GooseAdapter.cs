using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPatterns
{
    internal class GooseAdapter : Quackable
    {
        private readonly Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        internal override void Quack()
        {
            _goose.Honk();
        }
    }
}
