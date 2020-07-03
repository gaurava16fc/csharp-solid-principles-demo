using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.OCP
{
    public class TabloidReport : Report
    {
        public override void PrintReport()
        {
            ReportPrinter reportPrinter = new TabloidReportPrinter();
            reportPrinter.PrintReport();
        }
    }
}
