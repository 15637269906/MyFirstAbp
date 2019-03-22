using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstAbp.Localization;

namespace MyFirstAbp
{
    public class MyFirstAbpCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyFirstAbpLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstAbpCoreModule).GetAssembly());
        }
    }
}