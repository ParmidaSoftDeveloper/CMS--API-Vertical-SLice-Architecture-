using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Cms;
using Threenine.Configurations.PostgreSql;

namespace Database.Cmss.Configurations;

public class TagConfiguration : BaseEntityTypeConfiguration<Tag>
{
    public override void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.ToTable(nameof(Tag));
       
        builder.Property(x => x.Name)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.Permalink)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(35)
            .IsRequired();
        
        base.Configure(builder);
    }
}