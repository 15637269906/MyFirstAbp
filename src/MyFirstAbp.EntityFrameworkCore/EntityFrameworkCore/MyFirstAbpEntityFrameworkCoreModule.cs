using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyFirstAbp.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyFirstAbpCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyFirstAbpEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstAbpEntityFrameworkCoreModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();
        }
    }
}