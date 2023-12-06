using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevMVCApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account's Login action method.
        // ~/account/login?username=admin&password=manager
        public ActionResult Login(string Username, string Password) {
            if(Username == "admin" && Password == "manager") {
                return RedirectToAction("Dashboard", "Admin");
            } else {
                return RedirectToAction("InvalidLogin", "Account");
            }
        }

        // GET: InvalidLogin action method.
        public ActionResult InvalidLogin() {
            return View();
        }
    }
}