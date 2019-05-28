using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task2Mvc.Models
{
    public static class Helpers
    {
        public static MvcHtmlString Lists(this HtmlHelper html, List<string> list)
        {
            var div = new TagBuilder("div");
            var ul = new TagBuilder("ul");
            foreach (var element in list)
            {
                var li = new TagBuilder("li");
                li.SetInnerText(element);
                ul.InnerHtml += li.ToString();
            }
            div.InnerHtml += ul.ToString();
            return new MvcHtmlString(div.ToString());
        }

        public static MvcHtmlString CheckBoxes(this HtmlHelper html, List<string> list, string name)
        {
            string res = "";
            foreach (var elem in list)
            {
                var div = new TagBuilder("div");
                var box = new TagBuilder("input");
                box.MergeAttribute("type", "checkbox");
                box.MergeAttribute("id", elem);
                box.MergeAttribute("value", elem);
                box.MergeAttribute("name", name);
                div.InnerHtml += box.ToString();
                var label = new TagBuilder("label");
                label.MergeAttribute("for", elem);
                label.SetInnerText(elem);
                div.InnerHtml += label.ToString();
                res += div.ToString();
            }
            return new MvcHtmlString(res);
        }
    }
}