using System;
using System.Collections.Generic;
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    /// <summary>
    /// Provides actions with Reviews in BlogDb
    /// </summary>
    public class ReviewRepository : IRepository<Review>
    {
        private readonly DataContext _context;

        public ReviewRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public void Remove(Review review)
        {
            _context.Reviews.Remove(review);
            _context.SaveChanges();
        }

        public void RemoveAt(int index)
        {
            _context.Reviews.Add(_context.Reviews.Find(index) ?? throw new InvalidOperationException());
            _context.SaveChanges();
        }

        public IList<Review> GetAll() => new List<Review>(_context.Reviews);
    }
}