using ConsoleReportApp.Fonts;
using ConsoleReportApp.Patterns.Builder;
using ConsoleReportApp.Patterns.Facade;
using PdfSharp.Fonts;

namespace ConsoleReportApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GlobalFontSettings.FontResolver = new CustomFontResolver(); // Registra a fonte para poder exportar em formato PDF
            
            while (true)
            {
                Console.WriteLine("\nSelecione o tipo de relatório:");
                Console.WriteLine("1 - PDF");
                Console.WriteLine("2 - HTML");
                Console.WriteLine("3 - CSV");
                Console.WriteLine("0 - Sair");
                Console.Write("> ");

                var opcao = Console.ReadLine();

                if (opcao == "0")
                    break;

                IReportBuilder builder = opcao switch
                {
                    "1" => new PdfReportBuilder(),
                    "2" => new HtmlReportBuilder(),
                    "3" => new CsvReportBuilder(),
                    _ => null
                };

                if (builder == null)
                {
                    Console.WriteLine("\nOpção inválida!");
                    continue;
                }

                var manager = new ReportManager();
                manager.CriarEExecutarRelatorio(builder);
            }
        }
    }
}
