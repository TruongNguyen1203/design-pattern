namespace Builder.ReportBuilderDesignPattern;

public static class ReportClient
{
    public static void Main()
    {
        ReportDirector reportReportDirector = new ReportDirector();
        
        PdfReportBuilder pdfReportReport = new PdfReportBuilder();

        Report report = reportReportDirector.MakeReport(pdfReportReport);
        report.DisplayReport()
;
        ExcelReportBuilder excelReportBuilder = new ExcelReportBuilder();
        var excelReport = reportReportDirector.MakeReport(excelReportBuilder);
        excelReport.DisplayReport();
    }
}