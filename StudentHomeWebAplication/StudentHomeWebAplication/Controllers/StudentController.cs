using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentHomeWebAplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult MainPage()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}