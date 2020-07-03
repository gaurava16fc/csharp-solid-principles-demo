using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.POC.ReportGenerator.SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();
            report.PrintReport();

            Console.WriteLine("\n\nProgram ended, hit any key to continue....");
            Console.ReadKey();
        }
    }
}
