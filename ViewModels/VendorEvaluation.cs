using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMTVendorEvaluationWebApp.ViewModels
{
    public class VendorEvaluation
    {
        public int vendor_id { get; set; }
        
        public string CompanyName { get; set; }

        public double Score { get; set; }

        public double Percentage { get; set; }

        public int NumberOfProducts { get; set; }
    }
}
