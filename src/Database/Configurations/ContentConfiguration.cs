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
            .HasDefaultValue(ContentType.NotDefined)
            .HasConversion<string>();
        
        builder.Property(t => t.Status)
            .HasDefaultValue(ContentStatus.Draft)
            .HasConversion<string>();

       
        builder.Property(x => x.MetaDescription)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(330);

        builder.Property(x => x.MetaTitle)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(65);

        builder.Property(x => x.MetaRobots)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(35);

        builder.Property(x => x.MetaViewPort)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(30);
        
        base.Configure(builder);
    }
}