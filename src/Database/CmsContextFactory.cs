
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database.Cmss;

internal class CmsContextFactory : IDesignTimeDbContextFactory<CmsContext>
{
    public CmsContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<CmsContext> dbContextOptionsBuilder =
            new();

        dbContextOptionsBuilder.UseSqlServer(@"localBuild");
        return new CmsContext(dbContextOptionsBuilder.Options);
    }
}
