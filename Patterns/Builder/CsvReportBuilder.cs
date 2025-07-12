using ConsoleReportApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReportApp.Patterns.Builder
{
    internal class CsvReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public void BuildHeader() => _report.Header = "Chave,Valor";
        public void BuildContent() => _report.Content = SystemInfoCollector.GetCsvInfo();
        public void BuildFooter() => _report.Footer = $"Data de geração,{DateTime.Now}";
        public String Extension => ".csv";

        public Report GetReport() => _report;
    }
}
