namespace Command
{
    internal class SimpleRemoteControl
    {
        // private int slot;
        public ICommand[] onCommands { get; set; }
        public ICommand[] offCommands { get; set; }
        private ICommand lastCommand;

        public SimpleRemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonPressed(int slot)
        {
            lastCommand = onCommands[slot];
            lastCommand.Execute();
        }

        public void OffButtonPressed(int slot)
        {
            lastCommand = offCommands[slot];
            lastCommand.Execute();
        }

        public void UndoButtonPressed()
        {
            lastCommand.Undo();
        }
    }
}
