using ConsoleReportApp.Patterns.Builder;
using ConsoleReportApp.Patterns.Command;

namespace ConsoleReportApp.Patterns.Facade
{
    public class ReportManager
    {
        public void CriarEExecutarRelatorio(IReportBuilder builder)
        {
            builder.BuildHeader();
            builder.BuildContent();
            builder.BuildFooter();
            var report = builder.GetReport();

            var executor = new CommandExecutor();
            executor.AddCommand(new GenerateReportCommand(report));
            executor.AddCommand(new ExportReportCommand(report, builder.Extension));
            executor.ExecuteAll();
        }
    }
}
