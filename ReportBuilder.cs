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

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportFooter();
        public abstract void SetReportContent();

        public Report GetReport()
        {
            return reportObject;
        }
        public void CreateNewReport()
        {
            reportObject = new Report();
        }

    }
}
