using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class ReportBuilder
    {
        protected Report reportObject;

        public abstract ReportBuilder SetReportType();
        public abstract ReportBuilder SetReportHeader();
        public abstract ReportBuilder SetReportFooter();
        public abstract ReportBuilder SetReportContent();

        public Report GetReport()
        {
            return reportObject;
        }

        public ReportBuilder CreateNewReport()
        {
            reportObject = new Report();
            return this;
        }


    }
}
