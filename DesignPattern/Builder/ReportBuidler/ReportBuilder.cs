namespace Builder.ReportBuilderDesignPattern;

public abstract class ReportBuilder
{
    protected Report report;
    public abstract void BuildReportType();
    public abstract void BuildReportHeader();
    public abstract void BuildReportContent();
    public abstract void BuildReportFooter();

    public void CreateNewReport()
    {
        report = new Report();
    }

    public Report GetReport()
    {
        return report;
    }
    
}