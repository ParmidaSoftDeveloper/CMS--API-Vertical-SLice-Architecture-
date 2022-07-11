using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Cms;
using Threenine.Configurations.PostgreSql;

namespace Database.Cmss.Configurations;

public class ArticleConfiguration : BaseEntityTypeConfiguration<Article>
{
    public override void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.ToTable(nameof(Article));
       
        builder.Property(x => x.Title)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(75)
            .IsRequired();

        builder.Property(x => x.Summary)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(300)
            .IsRequired();

        builder.Property(x => x.Content)
            .HasColumnType(ColumnTypes.Text);
    }
}