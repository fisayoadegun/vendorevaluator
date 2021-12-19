using GMTVendorEvaluationWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMTVendorEvaluationWebApp.ViewModels
{
    public class VendorProductViewModel
    {
        public int vendor_id { get; set; }
        public int product_id { get; set; }
                
        public string ProductName { get; set; }

        public string CompanyName { get; set; }

        public string DepartmentName { get; set; }

        public DateTime Date_Delivered { get; set; }

        public double Score { get; set; }

        public double Percentage { get; set; }

        public IEnumerable<Vendor> Vendors { get; set; }
        public IEnumerable<Product_Service> Product_Services { get; set; }
        public IEnumerable<Evaluation> Evaluations { get; set; }
    }
}
