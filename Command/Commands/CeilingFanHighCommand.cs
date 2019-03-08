using System;

namespace Command
{
    public class CeilingFanHighCommand:ICommand
    {
        private CeilingFan _ceilingFan;
        private int _oldSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _oldSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
        }

        public void Undo()
        {
            if (_oldSpeed == Constants.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_oldSpeed == Constants.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_oldSpeed == Constants.LOW)
            {
                _ceilingFan.Low();
            }
            else if (_oldSpeed == Constants.OFF)
            {
                _ceilingFan.Off();
            }
        }
    }
}
