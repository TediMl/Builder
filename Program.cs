
using Builder;

class Program
{
    static void Main(string[] args)
    {
        PdfReport pdf=new PdfReport();
        ReportDirectory director = new ReportDirectory();
        Report report =director.ExecuteReport(pdf);
        report.DisplayReport();

        Console.WriteLine("**********");
        // Constructing the Excel Report
        // The Process is going to be the same
        ExcelReport excelReport = new ExcelReport();
        report =director.ExecuteReport(excelReport);
        report.DisplayReport();
        Console.ReadKey();
    }
}
