using System.Web.Mvc;
using DataLayer;
using DataLayer.Entities;

namespace Task2Mvc.Controllers
{
    public class ReviewController : Controller
    {
        /// <summary>
        /// Display reviews and provide form for adding new reviews
        /// </summary>
        public ActionResult Index(FormCollection form)
        {
            if (HttpContext.Request.RequestType == "POST")
            {
                using (var unit = new Unit())
                {
                    unit.ReviewRepository.Add(new Review() {Name = form["Name"], Content = form["Content"]});
                }
            }

            using (var unit = new Unit())
            {
                ViewData["unit"] = unit.ReviewRepository.GetAll();
            }

            return View("Index");
        }
    }
}