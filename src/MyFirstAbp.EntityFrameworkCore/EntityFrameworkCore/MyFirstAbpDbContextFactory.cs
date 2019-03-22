using MyFirstAbp.Configuration;
using MyFirstAbp.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyFirstAbp.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyFirstAbpDbContextFactory : IDesignTimeDbContextFactory<MyFirstAbpDbContext>
    {
        public MyFirstAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyFirstAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyFirstAbpConsts.ConnectionStringName)
            );

            return new MyFirstAbpDbContext(builder.Options);
        }
    }
}