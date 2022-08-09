using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Cms;
using Threenine.Configurations.PostgreSql;

namespace Database.Configurations;

public class ContentConfiguration : BaseEntityTypeConfiguration<Content>
{
    public override void Configure(EntityTypeBuilder<Content> builder)
    {
        builder.ToTable(nameof(Content));
       
        builder.Property(x => x.Title)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(75)
            .IsRequired();

        builder.Property(x => x.Summary)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(300)
            .IsRequired();

        builder.Property(x => x.Body)
            .HasColumnType(ColumnTypes.Text);

        builder.Property(x => x.ContentType)
            .HasDefaultValue(ContentType.NotDefined);
        
        builder.Property(t => t.Status)
            .HasDefaultValue(ContentStatus.Draft)
            .HasConversion<string>();

        builder.HasOne(x => x.Seo)
            .WithMany(s => s.Contents)
            .HasForeignKey(k => k.SeoId);
    }
}