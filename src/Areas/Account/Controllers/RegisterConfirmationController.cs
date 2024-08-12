// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using src.Areas.Account.Models;
using src.Data.Models;
using src.Service;

namespace Web_MVC_Commerce.Areas.Identity.Pages.Account
{
    [Area("Account")]
    [AllowAnonymous]
    [Route("[Area]/[action]")]
    public class RegisterConfirmationController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IEmailSender _sender;

        public RegisterConfirmationController(UserManager<User> userManager, IEmailSender sender)
        {
            _userManager = userManager;
            _sender = sender;
        }

        public async Task<IActionResult> RegisterConfirmation(string email, string returnUrl = null)
        {
            if (email == null)
            {
                return RedirectToAction("Index", "Home");
            }

            returnUrl = returnUrl ?? Url.Content("~/Product");
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }

            var model = new RegisterConfirmationViewModel
            {
                Email = email,
                DisplayConfirmAccountLink = true
            };

            if (model.DisplayConfirmAccountLink)
            {
                var userId = await _userManager.GetUserIdAsync(user);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                model.EmailConfirmationUrl = Url.Action(
                    action: "ConfirmEmail",
                    controller: "ConfirmEmail",
                    new { userId = userId, code = code, returnUrl = returnUrl },
                    protocol: Request.Scheme);
            }

            return View(model);
        }
    }
}
