using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class PublicController : Controller
    {
         // GET: /
         // GET: /Public/
        public ActionResult Index()
        {
            return View();
        }

    }
}
