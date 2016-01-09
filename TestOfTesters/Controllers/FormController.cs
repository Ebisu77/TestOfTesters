using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestOfTesters.Models;

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
        public ActionResult TestForm(FormModel myModel)
        {           

            return View("ProcessForm",myModel);
        }
    }
}