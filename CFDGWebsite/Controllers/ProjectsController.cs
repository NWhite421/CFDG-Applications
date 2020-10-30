using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CFDGWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects (redirects to home page)
        public ActionResult Index()
        {
            return View(Url.Action("Index", "Home"));
        }

        // GET: Projects/FieldDataSubmitter

        public ActionResult FieldDataSubmitter()
        {
            return View();
        }

        public ActionResult Civil3DPlugin()
        {
            return View();
        }
    }
}