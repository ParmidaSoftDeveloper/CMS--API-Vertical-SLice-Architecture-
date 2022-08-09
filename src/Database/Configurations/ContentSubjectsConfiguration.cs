using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Cms;
using Threenine.Configurations.PostgreSql;

namespace Database.Configurations;

public class ContentSubjectsConfiguration : IEntityTypeConfiguration<ContentSubject>
{
    public void Configure(EntityTypeBuilder<ContentSubject> builder)
    {
        builder.HasNoKey();
        builder.HasIndex(x => new { x.ContentId, x.SubjectId }).IsUnique()
            .HasDatabaseName("ContentSubject_unique_constraint");
        
        builder.Property(x => x.ContentId)
            .HasColumnType(ColumnTypes.UniqueIdentifier)
             .IsRequired();
        
        builder.Property(x => x.SubjectId)
            .HasColumnType(ColumnTypes.UniqueIdentifier)
            .IsRequired();
        

    }
}