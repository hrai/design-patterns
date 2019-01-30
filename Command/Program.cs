using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var remote =new SimpleRemoteControl();

            var light = new Light();
            var cmd = new LightOnCommand(light);
            remote.SetCommand(cmd);

            remote.ButtonPressed();
        }
    }
}
