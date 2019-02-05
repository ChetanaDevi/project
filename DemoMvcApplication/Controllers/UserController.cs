using Demo.Business;
using DemoMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMvcApplication.Controllers
{
    public class UserController : Controller
    {
        UserManager userManager = new UserManager();
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                bool isValidUser = userManager.ValidateUser(model.Username, model.Password);
                if(isValidUser)
                {
                    Session["User"] = model;
                    return RedirectToAction("Index", "Patient");
                }

                ModelState.AddModelError("InvalidUser", "Invalid Credentials");
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}