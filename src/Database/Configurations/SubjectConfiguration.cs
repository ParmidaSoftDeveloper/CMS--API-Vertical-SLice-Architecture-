using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Cms;
using Threenine.Configurations.PostgreSql;

namespace Database.Configurations;

public class SubjectConfiguration : BaseEntityTypeConfiguration<Subject>
{
    public override void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.ToTable(nameof(Subject));
       
        builder.Property(x => x.Name)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.Permalink)
            .HasColumnType(ColumnTypes.Varchar)
            .HasMaxLength(35)
            .IsRequired();
        
        builder.Property(x => x.SubjectType)
            .HasConversion<string>();
        
        base.Configure(builder);
    }
}