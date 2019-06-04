using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.UI.MobileControls;
using DataLayer;
using DataLayer.Entities;
using Task2Mvc.Models;
using WebGrease.Css.Extensions;

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
                    var list = form["Tags"];
                    unit.ArticleRepository.Add(new Article()
                    {
                        Name = form["Name"],
                        Content = form["Content"],
                        Date = DateTime.Parse(form["Date"]).ToString(CultureInfo.InvariantCulture),
                        Tags = list
                    });
                }
            }

            using (var unit = new Unit())
            {
                var list = unit.ArticleRepository.GetAll();
                foreach (var article in list)
                {
                    if (article.Content.Length > 200)
                    {
                        article.Content = article.Content.Substring(0, 200);
                    }
                }

                ViewData["unit"] = list;
            }

            return View("Index");
        }

        public ActionResult Details(int? id)
        {
            Article article;
            using (var unit = new Unit())
            {
                article = unit.ArticleRepository.GetAll().First(a => a.ArticleId == id);
            }

            if (article == null)
            {
                return HttpNotFound();
            }

            return View(new ArticleView()
            {
                Name = article.Name, Content = article.Content, Date = article.Date,
                Tags = article.Tags.Split(',').ToList()
            });
        }

        public ActionResult Vote()
        {
            return Content("Thank you for your response");
        }
    }
}