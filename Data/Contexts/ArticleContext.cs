using AriBilgi.ArticleApp.Data.Configurations;
using AriBilgi.ArticleApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AriBilgi.ArticleApp.Data.Contexts
{
    public class ArticleContext : DbContext
    {
        public DbSet<Article> articles { get; set; }
        public DbSet<Comment> comments { get; set; }

        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleConfigurations());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
