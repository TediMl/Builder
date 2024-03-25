using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //The Director Class in Builder Design Pattern is only responsible for executing the building steps in order.
    //These steps are so generic that these steps will produce different products.
    public class ReportDirectory
    {
       
            public Report ExecuteReport(ReportBuilder reportObject)
            {
                reportObject.CreateNewReport();
                reportObject.SetReportType();
                reportObject.SetReportHeader();
                reportObject.SetReportFooter();
                reportObject.SetReportContent();

                return reportObject.GetReport();

            }
        }
    }


