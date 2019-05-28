using System.Data.Entity;
using DataLayer.Entities;

namespace DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext() : base("BlogDb")
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}