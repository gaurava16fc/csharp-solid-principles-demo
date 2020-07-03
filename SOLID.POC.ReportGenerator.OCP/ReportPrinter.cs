using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.OCP
{
    public class ReportPrinter
    {
        public virtual void PrintReport()
        {
            DataAccessBase dataAccessBase = new DataAccessBase();
            ReportFormatter reportFormatter = new ReportFormatter();
            dataAccessBase.GetData();
            reportFormatter.FormatReport();
            Console.WriteLine("\nPrint the report via Laser printer....");
        }
    }
}
