namespace ConsoleReportApp.Patterns.Command
{
    public class CommandExecutor
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand command) => _commands.Add(command);

        public void ExecuteAll()
        {
            foreach (var command in _commands)
                command.Execute();
        }
    }
}
