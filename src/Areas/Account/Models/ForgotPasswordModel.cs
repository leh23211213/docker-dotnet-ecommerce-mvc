using System.ComponentModel.DataAnnotations;

namespace src.Areas.Account.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}