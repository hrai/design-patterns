namespace Command
{
    internal class SimpleRemoteControl
    {
        private ICommand slot;

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void ButtonPressed()
        {
            slot.Execute();
        }
    }
}
