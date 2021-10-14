using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GMTVendorEvaluationWebApp.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
