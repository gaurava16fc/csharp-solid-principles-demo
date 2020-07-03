using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.SRP
{
    public class ReportPrinter
    {
        DataAccessBase dataAccessBase = new DataAccessBase();
        ReportFormatter reportFormatter = new ReportFormatter();
        public void PrintReport()
        {
            dataAccessBase.GetData();
            reportFormatter.FormatReport();
            Console.WriteLine("\nPrint the report....");
        }
    }
}
