using ConsoleReportApp.Patterns.Builder;
using ConsoleReportApp.Utils;

namespace ConsoleReportApp.Patterns.Command
{
    public class ExportReportCommand : ICommand
    {
        private readonly Report _report;
        private readonly string _fileName;
        private readonly string _extension;

        public ExportReportCommand(Report report, string extension)
        {
            _report = report;
            _extension = extension;
            _fileName = $"relatorio_{DateTime.Now:yyyyMMdd_HHmmss}{extension}";
        }

        public void Execute()
        { 
            try
            {

                Console.WriteLine("\n[Comando] Exportando relatório para disco...");

                if (_extension == ".pdf")
                {
                    PdfExporter.Export(_report, _fileName);
                }
                else
                {
                    File.WriteAllText(_fileName, _report.ToString());
                }

                Console.WriteLine("Relatório exportado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao executar exportação de relatório: {e.Message}", e);
            }
        }
    }
}
