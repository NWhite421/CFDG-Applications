using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CFDGWebsite.Controllers
{
    public class SupportController : Controller
    {
        // GET: Support
        public ActionResult Index()
        {
            return View();
        }

        // GET: Support/FieldDataSubmitter
        public ActionResult FieldDataSubmitter()
        {
            return View();
        }
    }
}