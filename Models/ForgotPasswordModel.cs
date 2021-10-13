using System.ComponentModel.DataAnnotations;

namespace GMTVendorEvaluationWebApp.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
