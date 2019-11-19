using PattiFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PattiFlow.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(UserRoles roles)
        {
            if (roles.userName == "harish" && roles.password == "test123")
                return RedirectToAction("Index", "Purchase");
            else
                return Content("<h3>Invalid Username/Password</h3>");
        }
    }
}