using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CFDGWebsite.Controllers
{
    public class HomeController : Controller
    {

        // GET: /
        public ActionResult Index()
        {
            return View();
        }

        // GET: /About
        [Route("About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // GET: /Contact
        [Route("Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: /Licenses
        [Route("Licenses")]
        public ActionResult Licenses()
        {
            return View();
        }
    }
}