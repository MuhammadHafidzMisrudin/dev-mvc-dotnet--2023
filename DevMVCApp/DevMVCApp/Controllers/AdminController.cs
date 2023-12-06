using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevMVCApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin's Dashboard action method.
        public ActionResult Dashboard() {
            return View();
        }
    }
}