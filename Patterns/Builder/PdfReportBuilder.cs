using ConsoleReportApp.Utils;

namespace ConsoleReportApp.Patterns.Builder
{
    public class PdfReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public void BuildHeader() => _report.Header = "[PDF] Dignóstico do Sistema";
        public void BuildContent() => _report.Content = SystemInfoCollector.GetFormattedInfo();
        public void BuildFooter() => _report.Footer = "[PDF] Relatório gerado em: " + DateTime.Now;
        public String Extension => ".pdf";

        public Report GetReport() => _report;
    }
}
