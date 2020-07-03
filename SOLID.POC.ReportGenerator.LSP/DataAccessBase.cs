using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.LSP
{
    public class DataAccessBase
    {
        public void GetData()
        {
            Console.WriteLine("\nGet Data from the Repository....");
        }
    }
}
