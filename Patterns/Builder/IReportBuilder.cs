namespace ConsoleReportApp.Patterns.Builder
{
    public interface IReportBuilder
    {
        void BuildHeader();
        void BuildContent();
        void BuildFooter();
        Report GetReport();
        string Extension { get; }
    }
}
