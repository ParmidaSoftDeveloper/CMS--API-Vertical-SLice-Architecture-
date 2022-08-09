using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Models.Cms;
using Threenine;

namespace Database;

public class CmsContext : BaseContext<CmsContext>
{
    public CmsContext(DbContextOptions<CmsContext> options)
        : base(options)
    {
    }

    public DbSet<Content> Contents { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<ContentSubject> ContentSubjects { get; set; }
 
 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("cms");
         modelBuilder.HasPostgresExtension("uuid-ossp");
        
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}