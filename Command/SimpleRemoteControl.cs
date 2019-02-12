namespace Command
{
    internal class SimpleRemoteControl
    {
        // private int slot;
        public ICommand[] onCommands { get; set; }
        public ICommand[] offCommands { get; set; }

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
            onCommands[slot].Execute();
        }

        public void OffButtonPressed(int slot)
        {
            offCommands[slot].Execute();
        }
    }
}
