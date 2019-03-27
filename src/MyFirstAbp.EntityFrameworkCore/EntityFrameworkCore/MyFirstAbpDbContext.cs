using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstAbp.Roles;
using MyFirstAbp.Users;

namespace MyFirstAbp.EntityFrameworkCore
{
    public class MyFirstAbpDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyFirstAbpDbContext(DbContextOptions<MyFirstAbpDbContext> options) 
            : base(options)
        {

        }
      

        public DbSet<User> Users { get; set; }


        public DbSet<Role> Roles { get; set; }


    }
}
