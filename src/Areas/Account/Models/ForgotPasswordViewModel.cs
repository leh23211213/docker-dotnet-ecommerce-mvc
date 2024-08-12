using System.ComponentModel.DataAnnotations;

namespace src.Areas.Account.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
