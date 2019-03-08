using System;

namespace Command
{
    public class GarageDoorOpenCommand:ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Open();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
