using Blog.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Infrastructure.Data
{
    internal class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
