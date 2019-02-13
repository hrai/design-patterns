using System;

namespace Command
{
    public class CeilingFanLowCommand:ICommand
    {
        private CeilingFan _ceilingFan;
        private int _oldSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _oldSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Low();
        }

        public void Undo()
        {
            if (_oldSpeed == HIGH)
            {
                _ceilingFan.High();
            }
            else if (_oldSpeed == MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_oldSpeed == LOW)
            {
                _ceilingFan.Low();
            }
            else if (_oldSpeed == Off)
            {
                _ceilingFan.Off();
            }
        }
    }
}
