using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestOfTesters.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Instructions()
        {
            
            return View();
        }

        public ActionResult Contact()
        {
            
            return View();
        }
    }
}