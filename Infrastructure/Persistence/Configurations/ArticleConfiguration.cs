using Domain.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasOne(p => p.Media).WithMany().HasForeignKey(p=> p.MediaId).OnDelete(DeleteBehavior.SetNull);
    }
}