using System;
using System.Collections.Generic;
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    /// <summary>
    /// Provides actions with Articles in BlogDb
    /// </summary>
    public class ArticleRepository : IRepository<Article>
    {
        private readonly DataContext _context;

        public ArticleRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
        }

        public void Remove(Article article)
        {
            _context.Articles.Remove(article);
            _context.SaveChanges();
        }

        public void RemoveAt(int index)
        {
            _context.Articles.Remove(_context.Articles.Find(index) ?? throw new InvalidOperationException());
            _context.SaveChanges();
        }

        public IList<Article> GetAll() => new List<Article>(_context.Articles);
    }
}