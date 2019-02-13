using System;

namespace Command
{
    public class CeilingFan
    {
        private readonly string name;

        private readonly int HIGH = 3;
        private readonly int MEDIUM = 2;
        private readonly int LOW = 1;
        private readonly int OFF = 0;

        private int _speed = 0;

        public CeilingFan(string name)
        {
            this.name = name;
        }

        public int Speed()
        {
            return _speed;
        }

        public void High()
        {
            _speed = HIGH;
            System.Console.WriteLine($"{name} CeilingFan turned high");
        }

        public void Medium()
        {
            _speed = MEDIUM;
            System.Console.WriteLine($"{name} CeilingFan turned medium");
        }

        public void Low()
        {
            _speed = LOW;
            System.Console.WriteLine($"{name} CeilingFan turned low");
        }

        public void Off()
        {
            _speed = OFF;
            System.Console.WriteLine($"{name} CeilingFan turned off");
        }
    }
}
