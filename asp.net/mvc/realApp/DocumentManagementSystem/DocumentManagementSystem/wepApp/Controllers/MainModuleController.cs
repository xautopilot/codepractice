using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wepApp.Controllers
{
    public class MainModuleController : Controller
    {
        //
        // GET: /MainModule/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SCM()
        {
            return View();
        }
	}
}