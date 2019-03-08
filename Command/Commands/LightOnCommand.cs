using System;

namespace Command
{
    public class LightOnCommand:ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
