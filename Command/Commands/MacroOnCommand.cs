using System;
using System.Linq;

namespace Command
{
    public class MacroOnCommand:ICommand
    {
        private ICommand[] _commands;

        public MacroOnCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            System.Console.WriteLine($"Executing {nameof(MacroOnCommand)}...");
            _commands.ToList().ForEach(com => com.Execute());
            System.Console.WriteLine($"Finished executing {nameof(MacroOnCommand)}...");
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}
