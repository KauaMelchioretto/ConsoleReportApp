namespace ConsoleReportApp.Patterns.Builder
{
    public class Report
    {
        public String Header { get; set; }
        public String Content { get; set; }
        public String Footer { get; set; }

        public override string ToString()
        {
            return $"{Header}\n{Content}\n{Footer}";
        }
    }
}