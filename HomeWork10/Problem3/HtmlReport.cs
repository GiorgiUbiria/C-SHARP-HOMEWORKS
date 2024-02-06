using System.Text;

namespace HomeWork10.Problem3;

public class HtmlReport : IReport
{
    public void CreateReport(string header, string body, string footer)
    {
        var sb = new StringBuilder();
        sb.AppendLine("<!DOCTYPE html>");
        sb.AppendLine("<html>");
        sb.AppendLine("<head>");
        sb.AppendLine("<title>Report</title>");
        sb.AppendLine("</head>");
        sb.AppendLine("<body>");
        sb.AppendLine($"<header>{header}</header>");
        sb.AppendLine($"<main>{body}</main>");
        sb.AppendLine($"<footer>{footer}</footer>");
        sb.AppendLine("</body>");
        sb.AppendLine("</html>");
        File.WriteAllText("report.html", sb.ToString());
    }
}