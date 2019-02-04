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
            var lightOnCommand = new LightOnCommand(light);

            var lightOffCommand = new LightOffCommand(light);

            var garageDoor = new GarageDoor();
            var garageDoorCommand = new GarageDoorOpenCommand(garageDoor);

            // remote.SetCommand(lightOnCommand);
            // remote.ButtonPressed();

            // remote.SetCommand(garageDoorCommand);
            // remote.ButtonPressed();

            /* */


            remote.SetCommand(0, lightOnCommand, lightOffCommand);
            remote.OnButtonPressed(0);
        }
    }
}
