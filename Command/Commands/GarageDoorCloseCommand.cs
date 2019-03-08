using System;

namespace Command
{
    public class GarageDoorCloseCommand:ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorCloseCommand()
        {
        }

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Close();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
