using BlogApplicationAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogApplicationAPI.Data
{
    public class BlogApplicationDbContext : DbContext
    {
        public BlogApplicationDbContext()
        {
        }

        public BlogApplicationDbContext(DbContextOptions<BlogApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
    }
}
