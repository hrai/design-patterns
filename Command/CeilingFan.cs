using System;

namespace Command
{
    public class CeilingFan
    {
        private readonly string name;

        private int _speed = 0;

        public CeilingFan(string name)
        {
            this.name = name;
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public void High()
        {
            _speed = Constants.HIGH;
            System.Console.WriteLine($"{name} CeilingFan turned high");
        }

        public void Medium()
        {
            _speed = Constants.MEDIUM;
            System.Console.WriteLine($"{name} CeilingFan turned medium");
        }

        public void Low()
        {
            _speed = Constants.LOW;
            System.Console.WriteLine($"{name} CeilingFan turned low");
        }

        public void Off()
        {
            _speed = Constants.OFF;
            System.Console.WriteLine($"{name} CeilingFan turned off");
        }
    }
}
