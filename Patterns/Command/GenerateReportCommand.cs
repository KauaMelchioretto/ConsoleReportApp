using ConsoleReportApp.Patterns.Builder;

namespace ConsoleReportApp.Patterns.Command
{
    public class GenerateReportCommand : ICommand
    {
        private readonly Report _report;

        public GenerateReportCommand(Report report) => _report = report;

        public void Execute() {
            Console.WriteLine("\n [Comando] Gerando relatório...");
            Console.WriteLine(_report);
        }
    }
}
