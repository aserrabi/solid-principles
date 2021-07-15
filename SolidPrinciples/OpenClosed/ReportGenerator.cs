using SolidPrinciples.OpenClosed;
using SolidPrinciples.SR;

namespace SolidPrinciples.OpenClosed
{
    public class ReportGenerator
    {
        public string ReportType { get; set; }

        public void GenerateReport(Person person)
        {
            if (ReportType == "CRS")
            {
                // Report generation with person data in Crystal Report.
            }
            
            if (ReportType == "PDF")
            {
                // Report generation with person data in PDF.
            }
        }
    }
}