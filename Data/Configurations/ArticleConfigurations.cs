using AriBilgi.ArticleApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AriBilgi.ArticleApp.Data.Configurations
{
    public class ArticleConfigurations : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(x => x.Text).IsRequired().HasColumnType("nvarchar(MAX)");
            builder.Property(x => x.Title).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Author).IsRequired().HasMaxLength(250);

            builder.HasMany(x => x.comments).WithOne(x => x.Article).HasForeignKey(x => x.ArticleId);
        }
    }
}
