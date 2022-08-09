using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Cms;
using Threenine.Configurations.PostgreSql;

namespace Database.Configurations;

public class SeoConfiguration : BaseEntityTypeConfiguration<Seo>
{
    public override void Configure(EntityTypeBuilder<Seo> builder)
    {
        builder.ToTable(nameof(Seo).ToLower());
        
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