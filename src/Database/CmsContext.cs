using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Models.Cms;
using Threenine;

namespace Database.Cmss;

public class CmsContext : BaseContext<CmsContext>
{
    public CmsContext(DbContextOptions<CmsContext> options)
        : base(options)
    {
    }

    public DbSet<Content> Contents { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ContentTags> ContentTags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("cms");
         modelBuilder.HasPostgresExtension("uuid-ossp");
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}