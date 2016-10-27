using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dai.Blog.Web.Controllers
{

    public class HomeController : Controller
    {
        [Authorize(Roles = "Users")]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Test()
        {
            return View();
        }

    }
}