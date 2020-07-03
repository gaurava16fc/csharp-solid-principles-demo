using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.SRP
{
    public class Report
    {
        public void PrintReport()
        {
            ReportPrinter reportPrinter = new ReportPrinter();
            reportPrinter.PrintReport();
        }
    }
}
