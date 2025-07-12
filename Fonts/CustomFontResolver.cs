using PdfSharp.Fonts;

namespace ConsoleReportApp.Fonts
{
    public class CustomFontResolver : IFontResolver
    {
        private readonly string _fontPath = Path.Combine(AppContext.BaseDirectory, "fonts", "arial.ttf");

        public CustomFontResolver() {}

        public byte[] GetFont(string faceName)
        {
            return File.ReadAllBytes(_fontPath); // carrega o arquivo .ttf
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            return new FontResolverInfo("CustomFont");
        }
    }
}
