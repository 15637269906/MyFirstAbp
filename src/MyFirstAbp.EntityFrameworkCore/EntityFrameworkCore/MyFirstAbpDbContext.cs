using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstAbp.Pmgt.Auths;
using MyFirstAbp.Pmgt.RoleAuths;
using MyFirstAbp.Pmgt.SysRoles;
using MyFirstAbp.Pmgt.UserInfos;
using MyFirstAbp.Pmgt.UserRoles;
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
        public DbSet<Auth> Auth { get; set; }
        public DbSet<RoleAuth> RoleAuth { get; set; }
        public DbSet<SysRole> SysRole { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}
