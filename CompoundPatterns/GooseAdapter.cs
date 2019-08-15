using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundPatterns
{
    class GooseAdapter : IQuackable
    {
        private Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void Quack()
        {
            _goose.Honk();
        }
    }
}
