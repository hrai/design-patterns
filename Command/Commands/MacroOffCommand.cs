using System.Linq;

namespace Command
{
    internal class MacroOffCommand:ICommand
    {
        private ICommand[] _commands;

        public MacroOffCommand(ICommand[] commands)
        {
            _commands = commands;
        }
        
        public void Execute()
        {            
            System.Console.WriteLine($"Executing {nameof(MacroOffCommand)}...");
            _commands.ToList().ForEach(com => com.Execute());
            System.Console.WriteLine($"Finished executing {nameof(MacroOffCommand)}...");
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}