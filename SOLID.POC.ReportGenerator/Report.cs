using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator
{
    public class Report
    {
        private void GetData()
        {
            Console.WriteLine("\nGet Data from the Repository....");
        }

        private void FormatReport()
        {
            Console.WriteLine("\nFormat the report....");
        }

        public void PrintReport()
        {
            GetData();
            FormatReport();
            Console.WriteLine("\nPrint the report....");
        }
    }
}
