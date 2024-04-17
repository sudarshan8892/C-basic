using ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace ASP.NET_MVC.Controllers
{
    public class APPUsersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialViewForHomePage()
        {
            string Company = "DFW";
            if (Company.ToLower() == "dfw")
              ViewBag.Title = "Security & Smart Home | Dallas-Fort Worth | DFW Security";
            return PartialView("Home");

        }

        // GET: APPUsers
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (loginModel == null) { throw new Exception(""); }
            return View();
        }

    }
}