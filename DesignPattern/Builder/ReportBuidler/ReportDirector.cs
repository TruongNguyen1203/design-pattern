namespace Builder.ReportBuilderDesignPattern;

public class ReportDirector
{
    public Report MakeReport(ReportBuilder reportBuilder)
    {
        reportBuilder.CreateNewReport();
        reportBuilder.BuildReportType();
        reportBuilder.BuildReportHeader();
        reportBuilder.BuildReportContent();
        reportBuilder.BuildReportFooter();

        return reportBuilder.GetReport();
    }
}