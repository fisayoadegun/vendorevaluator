using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GMTVendorEvaluationWebApp.Models
{
    public class Department
    {
        public int departmentID { get; set; }

        [Display(Name = "Department Name")]
        public string department_name { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }
        public virtual IList<Product_Service> Products_Services { get; set; }
    }
}
