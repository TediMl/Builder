﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Footer :" + ReportFooter);
            Console.WriteLine("Content :" + ReportContent);

        }
    }
}
