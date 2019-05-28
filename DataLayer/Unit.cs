using System;
using DataLayer.Entities;
using DataLayer.Repositories;

namespace DataLayer
{
    public class Unit : IDisposable
    {
        private readonly DataContext _context = new DataContext();
        public IRepository<Article> ArticleRepository { get; private set; }
        public IRepository<Review> ReviewRepository { get; private set; }

        public Unit()
        {
            ArticleRepository = new ArticleRepository(_context);
            ReviewRepository = new ReviewRepository(_context);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}