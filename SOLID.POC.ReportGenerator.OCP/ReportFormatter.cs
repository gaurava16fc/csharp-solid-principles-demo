using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.OCP
{
    public class ReportFormatter
    {
        public virtual void FormatReport()
        {
            Console.WriteLine("\nFormat the report to '8-1/2 X 11' size");
        }
    }
}
