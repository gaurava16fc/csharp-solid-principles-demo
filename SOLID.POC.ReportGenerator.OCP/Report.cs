using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.OCP
{
    public class Report
    {
        public virtual void PrintReport()
        {
            ReportPrinter reportPrinter = new ReportPrinter();
            reportPrinter.PrintReport();
        }
    }
}
