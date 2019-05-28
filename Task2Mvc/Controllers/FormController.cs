using System.Collections.Generic;
using System.Web.Mvc;

namespace Task2Mvc.Controllers
{
    public class FormController : Controller
    {
        /// <summary>
        /// Display form for customer
        /// </summary>
        public ActionResult Index(FormCollection form)
        {
            if (HttpContext.Request.RequestType == "POST")
            {
                return View(form);
            }
            else
            {
                ViewData["cars"] = new List<string>() {"Ferrari", "Lamborghini", "Mercedes"};
                return View();
            }
        }
    }
}