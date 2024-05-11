using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ExcelReport : ReportBuilder
    {
        public override ReportBuilder SetReportType()
        {
            reportObject.ReportType = "Excel";
            return this;
        }

        public override ReportBuilder SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
            return this;
        }

        public override ReportBuilder SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
            return this;
        }

        public override ReportBuilder SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
            return this;
        }



    }
}
