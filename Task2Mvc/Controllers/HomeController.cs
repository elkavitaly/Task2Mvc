using System;
using System.Globalization;
using System.Web.Mvc;
using DataLayer;
using DataLayer.Entities;

namespace Task2Mvc.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Display articles and provide form for adding new articles
        /// </summary>
        public ActionResult Index(FormCollection form)
        {
            if (HttpContext.Request.RequestType == "POST")
            {
                using (var unit = new Unit())
                {
                    unit.ArticleRepository.Add(new Article()
                        {Name = form["Name"], Content = form["Content"], Date = DateTime.Parse(form["Date"]).ToString(CultureInfo.InvariantCulture)});
                }
            }

            using (var unit = new Unit())
            {
                ViewData["unit"] = unit.ArticleRepository.GetAll();
            }

            return View("Index");
        }
    }
}