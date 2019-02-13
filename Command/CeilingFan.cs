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

        private int speed = 0;

        public CeilingFan(string name)
        {
            this.name = name;
        }

        public void High()
        {
            speed = HIGH;
            System.Console.WriteLine($"{name} CeilingFan turned high");
        }

        public void Medium()
        {
            speed = MEDIUM;
            System.Console.WriteLine($"{name} CeilingFan turned medium");
        }

        public void Low()
        {
            speed = LOW;
            System.Console.WriteLine($"{name} CeilingFan turned low");
        }

        public void Off()
        {
            speed = OFF;
            System.Console.WriteLine($"{name} CeilingFan turned off");
        }
    }
}
