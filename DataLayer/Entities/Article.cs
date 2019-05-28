using System;

namespace DataLayer.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
    }
}