using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GMTVendorEvaluationWebApp.Models
{
    public class Vendor
    {
        public int vendorID { get; set; }
        [Display(Name = "Company Name")]
        public string company_name { get; set; }

        [Display(Name = "Contact Person")]
        public string contact_person { get; set; }

        [Display(Name = "Company Address")]
        public string company_address { get; set; }

        [Display(Name = "Type Of Business")]
        public string type_of_business { get; set; }

        [Display(Name = "Phone Number")]
        public string phone_number { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        public virtual IList<Product_Service> Products_Services { get; set; }
    }
}
