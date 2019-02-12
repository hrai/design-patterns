using System;

namespace Command
{
    public class CeilingFan
    {
        private readonly string name;

        private readonly int High = 3;
        private readonly int Medium = 2;
        private readonly int Low = 1;
        private readonly int Off = 0;

        private int speed = 0;

        public CeilingFan(string name)
        {
            this.name = name;
        }

        public void High()
        {
            speed = High;
            System.Console.WriteLine($"{name} CeilingFan turned high");
        }

        public void Medium()
        {
            speed = Medium;
            System.Console.WriteLine($"{name} CeilingFan turned medium");
        }

        public void Low()
        {
            speed = Low;
            System.Console.WriteLine($"{name} CeilingFan turned low");
        }

        public void Off()
        {
            speed = Off;
            System.Console.WriteLine($"{name} CeilingFan turned off");
        }
    }
}
