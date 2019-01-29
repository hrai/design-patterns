using System;

namespace Command
{
    class LightOnCommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.on();
        }
    }
}
