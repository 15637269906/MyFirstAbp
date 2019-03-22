using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstAbp.Web.Startup;
namespace MyFirstAbp.Web.Tests
{
    [DependsOn(
        typeof(MyFirstAbpWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyFirstAbpWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstAbpWebTestModule).GetAssembly());
        }
    }
}