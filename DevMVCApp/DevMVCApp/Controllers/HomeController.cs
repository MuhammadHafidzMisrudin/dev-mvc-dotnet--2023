using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() {
            return View();
        }

        public ActionResult Products() {
            return View("OurCompanyProducts");
        }

        public ActionResult Contact() { 
            return View("Contact"); 
        }

        // ~/home/getempname?empid=
        public ActionResult GetEmpName(int EmpId) {
            var employees = new[] {
                new { EmpId = 1, EmpName = "Scott", Salary = 8000 },
                new { EmpId = 2, EmpName = "Smith", Salary = 2540 },
                new { EmpId = 3, EmpName = "Allen", Salary = 9400 }
            };

            string matchName = null;
            foreach (var item in employees) {
                if (EmpId == item.EmpId) {
                    matchName = item.EmpName;
                }
            }

            // return View();
            return Content(matchName, "text/plain");
        }

        // ~/home/getpayslip?empid=
        public ActionResult GetPaySlip(int EmpId) {
            string fileName = "~/PaySlip" + EmpId + ".pdf";
            return File(fileName, "application/pdf");
        }

        // ~/home/empinstagrampage?empid=
        public ActionResult EmpInstagramPage(int EmpId) {
            var employees = new[] {
                new { EmpId = 1, EmpName = "Scott", Salary = 8000 },
                new { EmpId = 2, EmpName = "Smith", Salary = 2540 },
                new { EmpId = 3, EmpName = "Allen", Salary = 9400 }
            };

            string igUrl = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    igUrl = "https://www.instagram.com/emp" + EmpId;
                }
            }

            if(igUrl == null) {
                return Content("Invalid Employee Id");
            } else {
                return Redirect(igUrl);
            } 
        }

    }
}