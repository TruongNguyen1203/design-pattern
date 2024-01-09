namespace Builder.ReportBuilderDesignPattern;


public class ExcelReportBuilder : ReportBuilder
{
    public override void BuildReportType()
    {
        report.ReportType = "Excel";
    }

    public override void BuildReportHeader()
    {
        report.ReportHeader = "Excel Header";
    }

    public override void BuildReportContent()
    {
        report.ReportContent = "Excel Content";
    }

    public override void BuildReportFooter()
    {
        report.ReportFooter = "Excel Footer";
    }
}