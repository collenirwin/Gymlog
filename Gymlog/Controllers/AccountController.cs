using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymlog.Models;
using Gymlog.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gymlog.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly EmailSender _emailSender;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            EmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        [HttpGet]
        [AllowAnonymous]
        //returnUrl: url to return to if user was redirected here
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl; 
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model,string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                //creates the user
                var user = new ApplicationUser
                {
                    Email = model.Email,
                    UserName = model.UserName
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: true);
                    SendConfirmationEmail(user);
                    return redirectToLocal(returnUrl);
                }
                addErrors(result);

            }
            // pass in model to redisplay form with users perviously enterered info (username,email,etc) after a failure
            return View(model); 
        }

        [HttpGet] // serving login page
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            if(_signInManager.IsSignedIn(HttpContext.User))
            {
                return RedirectToAction(nameof(HomeController.Index), "Home"); // bring us home
            }
            // clear cookie to ensure clean login
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl; 
            return View();
        }

        [HttpPost] // submitting login page
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                string userName = model.UserName;

                if(userName.Contains("@")) // are the using their email to login
                {
                    var user = await _userManager.FindByEmailAsync(model.UserName);
                    if (user.UserName != null)
                    {
                        userName = user.UserName;
                    }
                    else
                    {
                        userName = "";
                    }
                    //userName = user?.UserName ?? ""; // set username to user.UserName if user.UserName != null else make ""
                }

                if (userName == "")
                {
                    ModelState.AddModelError("", "Your Username and password combination was incorrect.");
                }
                else
                {
                    var result = await _signInManager.PasswordSignInAsync(userName, model.Password,
                        isPersistent: true, lockoutOnFailure: true);

                    if(result.Succeeded)
                    {
                        return redirectToLocal(returnUrl);
                    }
                    else if (result.IsLockedOut)
                    {
                        return RedirectToAction(nameof(Lockout));
                    }
                    else // login failure
                    {
                        ModelState.AddModelError("", "Your Username and password combination was incorrect.");
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home"); // bring us home
        }

        [HttpGet] 
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId != null && token != null)
            {
                // get user by id
                var user = await _userManager.FindByEmailAsync(userId);

                if (user != null)
                {
                    // confirm email based on given toekn
                    var result = await _userManager.ConfirmEmailAsync(user, token);
                    if (result.Succeeded)
                    {
                        return View();
                    }
                }
            }
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model, string returnUrl = null)
        //{
        //    // get user tied to email submitted
        //    var user = await _userManager.FindByEmailAsync(model.Email);
        //    if (user != null)
        //    {
        //        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        //    }
        //}
        private async void SendConfirmationEmail(ApplicationUser user) 
        {
            // generate token
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            // create the confimation url with user ID and the toekn
            string confimationUrl = generateTokenUrl(nameof(ConfirmEmail), user.Id, token, Request.Scheme);

            //sender off
            _emailSender.SendEmailAsync(user.Email, "Confirming Gymlog Email Address",
                "This is your confirmation link for Gymlog. <br>" +
                "<a href='" + confimationUrl + "'> Click here to confirm email. </a>");

        }
        private IActionResult redirectToLocal(string url)
        {
            if (Url.IsLocalUrl(url))
            {
                return Redirect(url);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
        private string generateTokenUrl(string actionName,string userId, string token,string scheme)
        {
            return Url.Action(
                action: actionName,
                controller: "Account",
                values: new { userId, token },
                protocol: scheme);
        }
        private void addErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
        public IActionResult AddWorkout()
        {
            return View();
        }
    }
}