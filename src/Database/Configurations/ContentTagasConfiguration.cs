using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Cms;
using Threenine.Configurations.PostgreSql;

namespace Database.Cmss.Configurations;

public class ContentTagasConfiguration : IEntityTypeConfiguration<ContentTags>
{
    public void Configure(EntityTypeBuilder<ContentTags> builder)
    {
        builder.HasNoKey();
        builder.Property(x => x.ContentId)
            .HasColumnType(ColumnTypes.UniqueIdentifier)
             .IsRequired();
        
        builder.Property(x => x.TagId)
            .HasColumnType(ColumnTypes.UniqueIdentifier)
            .IsRequired();
    }
}