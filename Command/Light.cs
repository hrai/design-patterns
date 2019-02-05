using System;

namespace Command
{
    public class Light
    {
        private readonly string name;

        public Light(string name)
        {
            this.name = name;
        }
        public void On()
        {
            System.Console.WriteLine($"{name} Light turned on");
        }

        public void Off()
        {
            System.Console.WriteLine($"{name} Light turned off");
        }
    }
}
