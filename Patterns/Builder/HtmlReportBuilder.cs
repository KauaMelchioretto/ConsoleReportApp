using ConsoleReportApp.Utils;

namespace ConsoleReportApp.Patterns.Builder
{
    public class HtmlReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public void BuildHeader() => _report.Header = "<h1>HTML Cabeçalho</h1>";
        public void BuildContent() => _report.Content = $"<pre>{SystemInfoCollector.GetFormattedInfo()}</pre>";
        public void BuildFooter() => _report.Footer = "<footer>Gerado em: " + DateTime.Now + "</footer>";
        public String Extension => ".html";

        public Report GetReport() => _report;
    }
}
