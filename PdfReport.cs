using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{



    // By returning this, each method allows the next method in the chain to be called on the same ReportBuilder object.  
    public class PdfReport : ReportBuilder
        {
        public override ReportBuilder SetReportType()
        {
            reportObject.ReportType = "PDF";
            return this;
        }

        public override ReportBuilder SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
            return this;
        }

        public override ReportBuilder SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
            return this;
        }

        public override ReportBuilder SetReportContent()
        {
            reportObject.ReportContent = "PDF content section";
            return this;
        }
    }
    }


