using EddyProject.Models;
using EddyProject_Bo.ViewModel_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EddyProject.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authencation
        [Route("Login/Index")]
        [AllowAnonymous]
        public ActionResult Index(String returnURL)
        {
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.ReturnURL = returnURL;
            return View(userViewModel);
        }

        [Route("Login/DoLogin")]
        [AllowAnonymous]
        [HttpPost]
        public ActionResult DoLogin(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                if (userViewModel.Username == "admin" && userViewModel.Password == "admin")
                {
                    FormsAuthentication.SetAuthCookie(userViewModel.Username, false);
                    Session["IsAdmin"] = true;
                    return Redirect(userViewModel.ReturnURL);
                }
                else
                {
                    ModelState.AddModelError("error", "Invalid Username or password");
                    return View("Index", userViewModel);
                }
            }
            else
            {
                return View("Index", userViewModel);
            }
        }
    }
}