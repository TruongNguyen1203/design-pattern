namespace Builder.ReportBuilderDesignPattern;

public class PdfReportBuilder : ReportBuilder
{
    public override void BuildReportType()
    {
        report.ReportType = "Pdf";
    }

    public override void BuildReportHeader()
    {
        report.ReportHeader = "Pdf Header";
    }

    public override void BuildReportContent()
    {
        report.ReportContent = "Pdf Content";
    }

    public override void BuildReportFooter()
    {
        report.ReportFooter = "Pdf Footer";
    }
}