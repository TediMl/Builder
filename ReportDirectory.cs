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


        public ReportBuilder ExecuteReport(ReportBuilder reportObject)
        {
            reportObject.CreateNewReport()
                        .SetReportType()
                        .SetReportHeader()
                        .SetReportFooter()
                        .SetReportContent();

            return reportObject;
        }


    }
}
    


