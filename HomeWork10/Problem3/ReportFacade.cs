namespace HomeWork10.Problem3;

public class ReportFacade
{
    private IReport htmlReport;
    private IReport pdfReport;

    public ReportFacade()
    {
        htmlReport = new HtmlReport();
        pdfReport = new PdfReport();
    }

    public void CreateHtmlReport(string header, string body, string footer)
    {
        htmlReport.CreateReport(header, body, footer);
    }

    public void CreatePdfReport(string header, string body, string footer)
    {
        pdfReport.CreateReport(header, body, footer);
    }
}