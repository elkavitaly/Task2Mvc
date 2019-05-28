using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task2Mvc.Models
{
    public class ReviewView
    {
        public int ReviewId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }

        public ReviewView()
        {
            
        }
    }
}