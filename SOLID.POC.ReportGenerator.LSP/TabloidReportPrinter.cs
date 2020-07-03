using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.LSP
{
    public class TabloidReportPrinter : ReportPrinter
    {
        public override void PrintReport()
        {
            DataAccessBase dataAccessBase = new DataAccessBase();
            ReportFormatter reportFormatter = new TabloidReportFormatter();
            dataAccessBase.GetData();
            reportFormatter.FormatReport();
            Console.WriteLine("\nPrint the report via dot-matrix printer....");
        }
    }
}
