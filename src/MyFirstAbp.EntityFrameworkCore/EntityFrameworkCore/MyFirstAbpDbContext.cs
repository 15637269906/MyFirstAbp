using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstAbp.Student;
using MyFirstAbp.Tasks;
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
        public DbSet<TaskInfo> TaskInfo { get; set; }


        public DbSet<Students> Students { get; set; }


        public DbSet<User> Users { get; set; }


    }
}
