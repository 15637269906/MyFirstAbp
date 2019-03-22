using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstAbp.Configuration;
using MyFirstAbp.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MyFirstAbp.Web.Startup
{
    [DependsOn(
        typeof(MyFirstAbpApplicationModule), 
        typeof(MyFirstAbpEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyFirstAbpWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyFirstAbpWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyFirstAbpConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyFirstAbpNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyFirstAbpApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstAbpWebModule).GetAssembly());
        }
    }
}