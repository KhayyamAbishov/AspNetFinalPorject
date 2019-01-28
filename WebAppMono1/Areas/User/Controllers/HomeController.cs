using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMono1.Models;

namespace WebAppMono1.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        MonoDbEntities db = new MonoDbEntities();
        // GET: User/Home
        public ActionResult Index()
        {
            return View(db.Photos.ToList());
        }
    }
}