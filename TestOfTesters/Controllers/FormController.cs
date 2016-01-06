using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestOfTesters.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public ActionResult TestForm()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult ProcessForm()
        {

            return View();
        }
    }
}