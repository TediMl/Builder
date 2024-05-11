
using Builder;

class Program
{
    
        static void Main(string[] args)
        {
            ReportDirectory director = new ReportDirectory();

            
            Report pdfReport = director.ExecuteReport(new PdfReport()).GetReport();
            pdfReport.DisplayReport();

            Console.WriteLine("**********");

            
            Report excelReport = director.ExecuteReport(new ExcelReport()).GetReport();
            excelReport.DisplayReport();

            Console.ReadKey();
        }
    }


