using iTextSharp.text;
using iTextSharp.text.pdf;

namespace HomeWork10.Problem3;

public class PdfReport : IReport
{
    public void CreateReport(string header, string body, string footer)
    {
        Document document = new Document();
        PdfWriter.GetInstance(document, new FileStream("report.pdf", FileMode.Create));
        document.Open();
        document.Add(new Paragraph($"Header : {header}"));
        document.Add(new Paragraph($"Body : {body}"));
        document.Add(new Paragraph($"Footer: {footer}"));
        document.Close();
    }
}