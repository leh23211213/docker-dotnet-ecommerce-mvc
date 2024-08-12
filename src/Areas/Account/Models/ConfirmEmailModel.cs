using Microsoft.AspNetCore.Mvc;

namespace src.Areas.Account.Models
{
    public class ConfirmEmailModel
    {
        [TempData]
        public string StatusMessage { get; set; }
    }
}