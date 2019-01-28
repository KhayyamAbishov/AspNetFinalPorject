using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMono1.Areas.User.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: User/Projects
        public ActionResult Index()
        {
            return View();
        }
    }
}