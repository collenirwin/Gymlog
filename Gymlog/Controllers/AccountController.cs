using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymlog.Models;
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

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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

        private void addErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}