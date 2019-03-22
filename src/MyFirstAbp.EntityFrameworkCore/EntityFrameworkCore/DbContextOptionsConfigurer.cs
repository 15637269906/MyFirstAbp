using Microsoft.EntityFrameworkCore;

namespace MyFirstAbp.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyFirstAbpDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyFirstAbpDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
