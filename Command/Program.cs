using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var remote =new SimpleRemoteControl();

            var kitchenLight = new Light("kitchen light");
            var livingLight = new Light("living room light");
            var garageDoor = new GarageDoor();
            var stereo = new Stereo();

            var kitLightOnCommand = new LightOnCommand(kitchenLight);
            var kitLightOffCommand = new LightOffCommand(kitchenLight);

            var lightOnCommand = new LightOnCommand(livingLight);
            var lightOffCommand = new LightOffCommand(livingLight);

            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            var garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);

            var stereoOnWithCDCommand  = new StereoOnWithCDCommand(stereo);
            var stereoOffCommand  = new StereoOffCommand(stereo);

            remote.SetCommand(0, lightOnCommand, lightOffCommand);
            remote.SetCommand(1, kitLightOnCommand, kitLightOffCommand);
            remote.SetCommand(2, garageDoorOpenCommand, garageDoorCloseCommand);
            remote.SetCommand(3, stereoOnWithCDCommand, stereoOffCommand);

            remote.OnButtonPressed(0);
            remote.OffButtonPressed(0);
            remote.OnButtonPressed(1);
            remote.OffButtonPressed(1);
            remote.OnButtonPressed(2);
            remote.OffButtonPressed(2);
            remote.OnButtonPressed(3);
            remote.OffButtonPressed(3);
        }
    }
}
