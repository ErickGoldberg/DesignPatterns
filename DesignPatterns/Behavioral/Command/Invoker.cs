namespace DesignPatterns.Behavioral.Command
{
    public class Invoker
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void UndoCommands()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }

}
