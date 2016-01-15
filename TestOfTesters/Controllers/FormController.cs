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

            // mess with view if middle name have not been specified
            string middleNameTemp;

            if (myModel.StudentMiddleName == null)
            {
                // string saying null intentionally
                middleNameTemp = "null";
            }
            else
            {
                middleNameTemp = myModel.StudentMiddleName;
            }

            // crate full name in model
            myModel.FullName = myModel.StudentFirstName + " " + middleNameTemp + " " + myModel.StudentLastName;

            return View("ProcessForm",myModel);
        }
    }
}