using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.LSP
{
    public class LetterReport : Report
    {
        public override void PrintReport()
        {
            ReportPrinter reportPrinter = new LetterReportPrinter();
            reportPrinter.PrintReport();
        }
    }
}
