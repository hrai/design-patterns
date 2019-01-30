using System;

namespace Command
{
    public class GarageDoorCommand:ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.LightOn();
        }
    }
}
