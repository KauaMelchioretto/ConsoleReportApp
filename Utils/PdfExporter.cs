using ConsoleReportApp.Patterns.Builder;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace ConsoleReportApp.Utils
{
    public static class PdfExporter
    {
        public static void Export(Report report, string fileName)
        {
            var document = new PdfDocument();
            document.Info.Title = "Relatório do Sistema";

            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            var options = new XPdfFontOptions(PdfFontEncoding.Unicode, embedding: PdfFontEmbedding.Always);
            var font = new XFont("CustomFont", 12);

            var content = report.ToString().Split('\n');
            int y = 20;
            foreach (var line in content)
            {
                gfx.DrawString(
                    line,
                    font,
                    XBrushes.Black,
                    new XRect(20, y, page.Width - 40, 0),
                    XStringFormats.TopLeft
                );
                y += 20;
            }

            document.Save(fileName);
        }
    }
}
