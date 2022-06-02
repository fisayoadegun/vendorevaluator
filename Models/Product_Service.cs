using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GMTVendorEvaluationWebApp.Models
{
    public class Product_Service
    {
        
        public int product_serviceID { get; set; }
        [Display(Name = "Vendor")]
        public int vendorID { get; set; }
        [Display(Name = "Deparment")]
        public int departmentID { get; set; }

        [Display(Name = "Product/Service")]
        public string product_name { get; set; }
        [Display(Name = "Date Delivered")]
        public DateTime Date_delivered { get; set; }

        public bool Evaluated { get; set; }
        public bool departmental_evaluation { get; set; }

		public double Percentage { get; set; }

		public virtual IList<Evaluation> Evaluations { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual Department Department { get; set; }
    }
}
