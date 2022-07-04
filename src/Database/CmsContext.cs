using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Threenine;

namespace Database.Cmss;

public class CmsContext : BaseContext<CmsContext>
{
    public CmsContext(DbContextOptions<CmsContext> options)
        : base(options)
    {
    }

  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Cms");
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}