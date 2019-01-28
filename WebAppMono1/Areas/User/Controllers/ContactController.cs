using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMono1.Areas.User.Controllers
{
    public class ContactController : Controller
    {
        // GET: User/Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}