using System.Collections.Generic;

namespace Task2Mvc.Models
{
    public class ArticleView
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }
    }
}