
using System.ComponentModel.DataAnnotations;

namespace src.Areas.Account.Models
{
    public class ResendEmailConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}